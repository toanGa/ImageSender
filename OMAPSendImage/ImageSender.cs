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
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".JPEG", ".BMP", ".GIF", ".PNG" };
        const int BAUD_115200 = 115200;
        const int BAUD_9600 = 9600;
        const int BAUD_921600 = 921600;
        bool Canced = false;

        ManualResetEvent StartEvent = new ManualResetEvent(false);
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
                SendImageToOmap();
            };
            Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WaitWorkerComplete);
        }

        private void WaitWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            TraceLog("Send Image Completed!");
            buttonSend.Text = "Send";
            if(Canced)
            {
                // Do some task with background worker canced
                SetProgressBarValue(0);
            }
        }

        void SendImageToOmap()
        {
            string imgPath = textBoxLinkIMG.Text;
            Bitmap img = (Bitmap)Image.FromFile(imgPath);
            Color color;
            int height, width;
            int i, j;
            byte[] sendPixel = new byte[3];

            height = img.Height;
            width = img.Width;

            Canced = false;
            //Set baudrate when request
            if (serialPortOmap.IsOpen)
            {
                TraceLog("Close 1");
                serialPortOmap.Close();
            }
            serialPortOmap.BaudRate = BAUD_115200;
            serialPortOmap.DataReceived += serialPortOmap_DataReceived;
            TraceLog("Open 1");
            serialPortOmap.Open();

            // clear buffer
            serialPortOmap.DiscardInBuffer();

            // Notify OMAP will be get image
            serialPortOmap.Write("GET_IMG");
 
            // Wait For OMAP respond
            StartEvent.Reset();
            bool waiteStatus = StartEvent.WaitOne(3000);

            if(waiteStatus == false)
            {
                TraceLog("Timeout wait respond from OMAP!");
                return;
            }

            TraceLog("Start send Image data to OMAP");


            if (serialPortOmap.IsOpen)
            {
                TraceLog("Close 2");
                serialPortOmap.Close();
            }
            serialPortOmap.DataReceived -= serialPortOmap_DataReceived;
            //serialPortOmap.BaudRate = BAUD_921600;
            TraceLog("Open 2");
            serialPortOmap.Open();


            DateTime start = DateTime.Now;

            SetProgressBarValue(0);

            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    color = img.GetPixel(j, i);
                    sendPixel[0] = color.R;
                    sendPixel[1] = color.G;
                    sendPixel[2] = color.B;

                    //TraceLog("Send " + i + ":" + j + "\r\n");
                    serialPortOmap.Write(sendPixel, 0, sendPixel.Length);
                    //if(j % 20 == 0)
                    //{
                    //    Thread.Sleep(1);
                    //}
                }
                SetProgressBarValue(i + 1);
                if(Worker.CancellationPending)
                {
                    TraceLog("Canced background worker!");
                    Canced = true;
                    return;
                }
            }
            DateTime done = DateTime.Now;

           TraceLog(String.Format("Start: {0}, Done {1}", start.ToString(), done.ToString()));
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

        void SetProgressBarValue(int value)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    progressBarPercent.Value = value;
                });
            }
            else
            {
                progressBarPercent.Value = value;
            }
        }

        private void serialPortOmap_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comport = sender as SerialPort;
            string content = comport.ReadExisting();

            if (content == "SEND_ME")
            {
                TraceLog("SEND_ME received");
                TraceLog("Sender: Set");

                Thread.Sleep(10);
                StartEvent.Set();
            }
            else
            {
                TraceLog(content);
            }
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (!serialPortOmap.IsOpen)
            {
                serialPortOmap.PortName = comboBoxOmapCOM.Text;
                try
                {
                    serialPortOmap.Open();
                    TraceLog("Open 3");
                    buttonOpenPort.Text = "Close";
                    TraceLog("Open serial port: " + serialPortOmap.PortName);
                }
                catch(Exception ex)
                {
                    TraceLog(ex.Message);
                }
            }
            else
            {
                try
                {
                    TraceLog("Close 3");
                    serialPortOmap.Close();
                    TraceLog("Close serial port: " + serialPortOmap.PortName);
                }
                catch
                {
                    MessageBox.Show("Serial port is open in another process");
                }

                buttonOpenPort.Text = "Open";
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
                bool isImage = false;
                string fileName = openFileDialog1.FileName;

                foreach (string ext in ImageExtensions)
                {
                    if(fileName.ToUpper().Contains(ext))
                    {
                        isImage = true;
                        break;
                    }
                }

                if(isImage)
                {
                    Image img = Image.FromFile(fileName);
                    if(img.Width == 240 && img.Height == 320)
                    {
                        textBoxLinkIMG.Text = fileName;
                        pictureBox1.Image = img;
                    }
                    else
                    {
                        img.Dispose();
                        MessageBox.Show("Image Dimension must be: 240 - 320");
                    }
                }
                else
                {
                    MessageBox.Show("You must select a Image");
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(!File.Exists(textBoxLinkIMG.Text))
            {
                MessageBox.Show("File not existed!");
                return;
            }
            if(!Worker.IsBusy)
            {
                Worker.RunWorkerAsync();
                buttonSend.Text = "Cancel";
            }
            else
            {
                Worker.CancelAsync();
                buttonSend.Text = "Send";
            }
        }

        private void comboBoxOmapCOM_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxOmapCOM.DataSource = ports;

            if (ports.Length > 0)
            {
                comboBoxOmapCOM.Text = ports[0];
            }
        }

        private void ImageSender_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPortOmap.IsOpen)
            {
                serialPortOmap.Close();
            }
        }

        private void serialPortOmap_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }

        private void serialPortOmap_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    buttonOpenPort.Text = "Open";
                });
            }
            else
            {
                buttonOpenPort.Text = "Open";
            }

            TraceLog("Pin PORT has changed");
        }
    }
}
