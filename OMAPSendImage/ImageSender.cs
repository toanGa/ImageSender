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
        object LockSystemStatus = new object();
        int mDotCount = 0;
        ManualResetEvent StartEvent = new ManualResetEvent(false);
        ManualResetEvent TrackingEvent = new ManualResetEvent(false);
        BackgroundWorker Worker = new BackgroundWorker();
        BackgroundWorker TrackingWorker = new BackgroundWorker();
        SystemStatus mSystemStatus = SystemStatus.FINDING_DEVICE;

        enum SystemStatus
        {
            FINDING_DEVICE,
            CONNECTED_DEVICE,
            DISCONECTED_DEVICE,
        }


        public ImageSender()
        {
            InitializeComponent();

            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += delegate
            {
                SendImageToOmap();
            };
            Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WaitWorkerComplete);

            TrackingWorker.WorkerReportsProgress = true;
            TrackingWorker.WorkerSupportsCancellation = true;
            TrackingWorker.DoWork += delegate
            {
                SystemTracking();
            };
            TrackingWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SystemTrackingComplete);
            TrackingWorker.RunWorkerAsync();

            PrintSystemInfo();

            // Disable for relesae mode
            //textBoxLOG.Visible = false;
        }

        private void SystemTrackingComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void SystemTracking()
        {
            SetSystemStatus(SystemStatus.FINDING_DEVICE);
            while(true)
            {
                while (true)
                {
                    // Find device first
                    if (GetSystemStatus() != SystemStatus.CONNECTED_DEVICE)
                    {
                        SerialPortDetecter detecter = new SerialPortDetecter();
                        string s = detecter.DetectPort("PING", "XPHONE", 1000);
                        // if finding decice success
                        if (!string.IsNullOrEmpty(s))
                        {
                            // Open serial port if find device
                            serialPortOmap.PortName = s;
                            serialPortOmap.Open();

                            // set system status
                            SetSystemStatus(SystemStatus.CONNECTED_DEVICE);
                            break;
                        }
                    }
                }

                // Wait for system raise event
                TrackingEvent.Reset();
                TrackingEvent.WaitOne();
            }
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
                try
                {
                    serialPortOmap.Close();
                }
                catch
                {
                    SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                    TrackingEvent.Set();
                    return;
                }
            }

            serialPortOmap.BaudRate = BAUD_115200;
            serialPortOmap.DataReceived += serialPortOmap_DataReceived;
            TraceLog("Open 1");
            try
            {
                serialPortOmap.Open();
            }
            catch
            {
                SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                TrackingEvent.Set();
                return;
            }
           

            // clear buffer
            serialPortOmap.DiscardInBuffer();

            try
            {
                // Notify OMAP will be get image
                serialPortOmap.Write("GET_IMG");
            }
            catch
            {
                SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                TrackingEvent.Set();
                return;
            }


            // Wait For OMAP respond
            StartEvent.Reset();
            bool waiteStatus = StartEvent.WaitOne(3000);

            if(waiteStatus == false)
            {
                MessageBox.Show("Phone may be sleep or not connected to PC");
                return;
            }

            TraceLog("Start send Image data to OMAP");


            if (serialPortOmap.IsOpen)
            {
                TraceLog("Close 2");
                try
                {
                    serialPortOmap.Close();
                }
                catch
                {
                    SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                    TrackingEvent.Set();
                    return;
                }
            }

            serialPortOmap.DataReceived -= serialPortOmap_DataReceived;
            try
            {
                TraceLog("Open 2");
                serialPortOmap.Open();
            }
            catch
            {
                SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                TrackingEvent.Set();
                return;
            }

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

                    try
                    {
                        serialPortOmap.Write(sendPixel, 0, sendPixel.Length);
                    }
                    catch
                    {
                        SetSystemStatus(SystemStatus.DISCONECTED_DEVICE);
                        TrackingEvent.Set();
                        return;
                    }
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

        /// <summary>
        /// show system info
        /// </summary>
        void PrintSystemInfo()
        {
            string systemInfo = "";
            Color trackingColor = Color.Black;
            labelMoreInfo.Text = "";

            switch (GetSystemStatus())
            {
                case SystemStatus.FINDING_DEVICE:
                    systemInfo = "Finding Phone";
                    trackingColor = Color.Olive;
                    labelMoreInfo.ForeColor = trackingColor;
                    labelMoreInfo.Text = "(Make sure phone connected and wakeup)";
                    break;
                case SystemStatus.CONNECTED_DEVICE:
                    systemInfo = "Phone Connected";
                    trackingColor = Color.Green;
                    break;
                case SystemStatus.DISCONECTED_DEVICE:
                    systemInfo = "Phone Disconnected";
                    trackingColor = Color.Red;
                    break;
                default:
                    break;
            }

            mDotCount++;
            if (mDotCount > 10)
            {
                mDotCount = 0;
            }

            for (int i = 0; i < mDotCount; i++)
            {
                systemInfo += " .";
            }

            labelSystemTracking.Text = systemInfo;
            labelSystemTracking.ForeColor = trackingColor;
        }

        void SetSystemStatus(SystemStatus status)
        {
            lock(LockSystemStatus)
            {
                mSystemStatus = status;
            }
        }

        SystemStatus GetSystemStatus()
        {
            SystemStatus status;
            lock (LockSystemStatus)
            {
                status = mSystemStatus;
            }
            return status;
        }

        private void serialPortOmap_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comport = sender as SerialPort;
            if(comport.IsOpen)
            {
                string content = comport.ReadExisting();

                if (content.Contains("SEND_ME"))
                {
                    TraceLog("SEND_ME received");
                    TraceLog("Sender: Set");

                    Thread.Sleep(10);
                    StartEvent.Set();
                }
                else
                {
                    //TraceLog(content);
                }
            }
            else
            {
                TraceLog("Receive serial data while serial port closed");
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
            if(GetSystemStatus() != SystemStatus.CONNECTED_DEVICE)
            {
                return;
            }

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
                DialogResult dialogResult = MessageBox.Show("Do you want stop sending image?", "Cancel sending image", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Worker.CancelAsync();
                    buttonSend.Text = "Send";
                }
                else if (dialogResult == DialogResult.No)
                {
                }
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
            TraceLog("Error received");
        }

        private void serialPortOmap_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            TraceLog("Pin Changed");
        }

        private void timerTracking_Tick(object sender, EventArgs e)
        {
            PrintSystemInfo();
        }

    }
}
