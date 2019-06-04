using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMAPSendImage
{
    /// <summary>
    /// This class use for test communication
    /// </summary>
    public partial class ImageSender : Form
    {
        ManualResetEvent RecvEvent = new ManualResetEvent(false);
        ManualResetEvent StartEvent = new ManualResetEvent(false);

        ConcurrentQueue<Byte[]> mQueueRecv = new ConcurrentQueue<Byte[]>();
        BackgroundWorker Worker = new BackgroundWorker();
        Bitmap OmapBMP = new Bitmap(240, 320, PixelFormat.Format24bppRgb);

        public ImageSender()
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
            MessageBox.Show("Send Image Complete");
        }

        void HandlerSerialRecev()
        {
            string imgPath = textBoxLinkIMG.Text;
            Bitmap img = (Bitmap)Image.FromFile(imgPath);
            Color color;
            int height, width;
            int i, j;
            byte[] sendPixel = new byte[3];

            height = img.Height;
            width = img.Width;

            StartEvent.Reset();
            StartEvent.WaitOne();
            TraceLog("Have request Get Image");

            if(serialPortOmap.IsOpen)
            {
                serialPortOmap.Close();
                serialPortOmap.DataReceived -= serialPortOmap_DataReceived;
                serialPortOmap.Open();
            }

            DateTime start = DateTime.Now;
            for (i = 0; i < width; i++)
            {
                for (j = 0; j < height; j++)
                {
                    color = img.GetPixel(i, j);
                    sendPixel[0] = color.R;
                    sendPixel[1] = color.G;
                    sendPixel[2] = color.B;

                    //TraceLog("Send " + i + ":" + j + "\r\n");
                    serialPortOmap.Write(sendPixel, 0, sendPixel.Length);
                    if(j % 20 == 0)
                    {
                        Thread.Sleep(1);
                    }
                    //Thread.Sleep(1);
                }
            }

            DateTime done = DateTime.Now;

            //MessageBox.Show(String.Format("Start: {0}, Done {1}", start.ToString(), done.ToString()));
        }

        void TraceLog(string log)
        {
#if true
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


        private void serialPortOmap_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comport = sender as SerialPort;
            string content = comport.ReadExisting();

            if (content == "IMG START")
            {
                StartEvent.Set();
            }
            else if (content == "SEND_ME")
            {
                TraceLog("SEND_ME received");
                TraceLog("Sender: Set");
                RecvEvent.Set();
            }
            else if (content == "FINISH")
            {
                TraceLog("FINISH Send image");
            }
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (!serialPortOmap.IsOpen)
            {
                serialPortOmap.PortName = comboBoxOmapCOM.Text;
                serialPortOmap.Open();
                TraceLog("Open serial port: " + serialPortOmap.PortName);
            }
            else
            {
                MessageBox.Show("Serial port is open in another process");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Open Image to Send",

                CheckFileExists = true,
                CheckPathExists = true,

                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxLinkIMG.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(textBoxLinkIMG.Text);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if(!File.Exists(textBoxLinkIMG.Text))
            {
                MessageBox.Show("File not existed!");
                return;
            }
            if(!Worker.IsBusy)
            {
                Worker.RunWorkerAsync();
            }
        }
    }
}
