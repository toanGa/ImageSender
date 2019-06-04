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
        ManualResetEvent RecvEvent = new ManualResetEvent(false);
        ConcurrentQueue<Byte[]> mQueueRecv = new ConcurrentQueue<Byte[]>();
        BackgroundWorker Worker = new BackgroundWorker();
        Bitmap OmapBMP = new Bitmap(240, 320, PixelFormat.Format24bppRgb);
        int LenDataRecv = 0;

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

        static int lenRecv = 0;
        byte[] arrRecv = new byte[240 * 320 * 3];
        void HandlerSerialRecev()
        {
            byte[] deqArr;
            int bytesRecv;
            int i, j;
            int row = 0;
            int col = 0;
            int idxPixel = 0;
            
            byte readByte;

            serialPortOmap.DiscardInBuffer();

            serialPortOmap.Write("IMG START");

            while(true)
            {
                readByte = (byte)serialPortOmap.ReadByte();
                arrRecv[lenRecv] = readByte;
                lenRecv++;
                if (lenRecv >= 240 * 320 * 3)
                {
                    TraceLog("Receive full package");

                    break;
                }
                else
                {
                    //Console.WriteLine(lenRecv);
                }
            }

            int idxSetPixel = 0;
            Color setColor;
            for (i = 0; i < 240; i++)
            {
                for (j = 0; j < 320; j ++)
                {
                    setColor = Color.FromArgb(arrRecv[idxSetPixel], arrRecv[idxSetPixel + 1], arrRecv[idxSetPixel + 2]);
                    OmapBMP.SetPixel(i, j, setColor);
                    idxSetPixel += 3;
                }
            }

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    pictureBox1.Image = new Bitmap(OmapBMP);
                });
            }
            else
            {
                pictureBox1.Image = new Bitmap(OmapBMP);
            }
        }

        void TraceLog(string log)
        {
#if false
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
#else
            Console.WriteLine(log);
#endif
        }

        private void buttonGetImage_Click(object sender, EventArgs e)
        {
            if (!Worker.IsBusy)
            {
                Worker.RunWorkerAsync();

            }
        }

        private void buttonSendImage_Click(object sender, EventArgs e)
        {
            ImageSender imgsender = new ImageSender();
            imgsender.Show();
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
