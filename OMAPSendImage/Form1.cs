using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMAPSendImage
{
    public partial class Form1 : Form
    {
        enum Command
        {
            CMD_NON,
            CMD_SEND,
            CMD_RECV,
        }


        ManualResetEvent RecvEvent = new ManualResetEvent(false);
        ConcurrentQueue<Byte[]> mQueueRecv = new ConcurrentQueue<Byte[]>();
        BackgroundWorker Worker = new BackgroundWorker();
        Bitmap OmapBMP = new Bitmap(240, 320, PixelFormat.Format24bppRgb);
        Command mCommand;
    
        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            comboBoxOmapCOM.DataSource = ports;

            if (ports.Length > 0)
            {
                comboBoxOmapCOM.Text = ports[0];
            }

            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += delegate
            {
                HandlerSerialRecev();
            };
            Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WaitWorkerComplete);
        }

        private void WaitWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Worker Complete");
            
        }

        void HandlerSerialRecev()
        {
            byte[] deqArr;
            int bytesRecv;
            int i;
            int row = 0;
            int col = 0;

            serialPortOmap.Write("START_IMG");

            while(true)
            {
                TraceLog("Receiver Wait");
                RecvEvent.Reset();
                RecvEvent.WaitOne();

                bool status = mQueueRecv.TryDequeue(out deqArr);

                if (status)
                {
                    bytesRecv = deqArr.Length;
                    for(i = 0; i < bytesRecv; i += 3)
                    {
                        OmapBMP.SetPixel(row, col, Color.FromArgb(deqArr[i], deqArr[i + 1], deqArr[i + 2]));

                        col++;
                        if(col >= 240)
                        {
                            col = 0;
                            row++;
                            if(row == 320)
                            {
                                // Finish Receive sequence
                                return;
                            }
                        }
                    }
                    TraceLog("Receiver: Write SEND_ME");
                    serialPortOmap.Write("SEND_ME");
                }
            }
        }

        void TraceLog(string log)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    textBoxLOG.AppendText(log + "\r\n");
                });
            }
            else
            {
                textBoxLOG.AppendText(log + "\r\n");
            }
        }

        private void serialPortOmap_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comport = sender as SerialPort;

            if(mCommand == Command.CMD_RECV)
            {
                int bytes = comport.BytesToRead;
                byte[] buffer = new byte[bytes];
                comport.Read(buffer, 0, bytes);

                mQueueRecv.Enqueue(buffer);
                TraceLog("Receiver: Set");
                RecvEvent.Set();
            }
            else if(mCommand == Command.CMD_SEND)
            {
                string content = comport.ReadExisting();
                if(content == "SEND_ME" || true)
                {
                    TraceLog("SEND_ME received");
                    TraceLog("Sender: Set");
                    RecvEvent.Set();
                }
            }

        }

        private void buttonGetImage_Click(object sender, EventArgs e)
        {
            mCommand = Command.CMD_RECV;

            if (!Worker.IsBusy)
            {
                Worker.RunWorkerAsync();
            }
        }

        private void buttonSendImage_Click(object sender, EventArgs e)
        {
            string imgPath = textBoxLinkIMG.Text;

            Bitmap img = (Bitmap)Image.FromFile(imgPath);
            Color color;
            int row, col;
            int i, j;
            byte[] sendPixel = new byte[3];

            mCommand = Command.CMD_SEND;

            row = img.Height;
            col = img.Width;
            
            for(i = 0; i < row; i++)
            {
                for(j = 0; j < col; j++)
                {
                    color = img.GetPixel(i, j);
                    sendPixel[0] = color.R;
                    sendPixel[1] = color.G;
                    sendPixel[2] = color.B;

                    serialPortOmap.Write(sendPixel, 0, sendPixel.Length);

                    TraceLog("Send " + i + "\r\n");

                    if (i < row - 1)
                    {
                        TraceLog("Sender: Wait");
                        RecvEvent.Reset();
                        RecvEvent.WaitOne();
                    }
                }


            }
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if(!serialPortOmap.IsOpen)
            {
                serialPortOmap.PortName = comboBoxOmapCOM.Text;
                serialPortOmap.Open();
            }
            else
            {
                MessageBox.Show("Serial port is open in another process");
            }
        }
    }
}
