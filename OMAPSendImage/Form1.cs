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
            //MessageBox.Show("Worker Complete");
            TraceLog("Receive Image complete!");
        }

        static int lenRecv = 0;
        byte[] arrRecv = new byte[240 * 320 * 3];
        bool hasImage = false;
        void HandlerSerialRecev()
        {
            int i, j;
            byte readByte;

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    buttonSave.Enabled = false;
                });
            }
            else
            {
                buttonSave.Enabled = false;
            }

            serialPortOmap.DiscardInBuffer();

            serialPortOmap.Write("IMG START");
            lenRecv = 0;
            while (true)
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
            for (i = 0; i < 320; i++)
            {
                for (j = 0; j < 240; j ++)
                {
                    setColor = Color.FromArgb(arrRecv[idxSetPixel], arrRecv[idxSetPixel + 1], arrRecv[idxSetPixel + 2]);
                    OmapBMP.SetPixel(j, i, setColor);
                    idxSetPixel += 3;
                }
            }

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    pictureBox1.Image = new Bitmap(OmapBMP);
                    buttonSave.Enabled = true;
                    hasImage = true;
                });
            }
            else
            {
                pictureBox1.Image = new Bitmap(OmapBMP);
                buttonSave.Enabled = true;
                hasImage = true;
            }
            
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
                buttonOpenPort.Text = "Close";
            }
            else
            {
                
                if (!Worker.IsBusy)
                {
                    try
                    {
                        serialPortOmap.Close();
                        buttonOpenPort.Text = "Open";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Worker is busy");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // using GUI to save file
#if false
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Title = "Save Image file",

                DefaultExt = "png",
                Filter = "Image files (*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(dialog.FileName))
                {
                    DialogResult dialogResult = MessageBox.Show("Override file?", "File existed", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OmapBMP.Save(dialog.FileName, ImageFormat.Jpeg);
                        TraceLog("File saved");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    OmapBMP.Save(dialog.FileName, ImageFormat.Jpeg);
                    TraceLog("File saved");
                }
            }
#endif
            if(hasImage)
            {
                DateTime dt = DateTime.Now;
                string nameFileSave = string.Format("{0}_{1}_{2}_{3}h{4}m{5}s.png", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                string foder = textBoxFoderSaveImage.Text;
                if (!Directory.Exists(foder))
                {
                    Directory.CreateDirectory(foder);
                }

                string saveFile = foder + "\\" + nameFileSave;
                OmapBMP.Save(saveFile, ImageFormat.Png);
                TraceLog("Saved file: " + Path.GetFullPath(saveFile));
            }
        }
    }
}
