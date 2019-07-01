namespace OMAPSendImage
{
    partial class ImageSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLOG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.comboBoxOmapCOM = new System.Windows.Forms.ComboBox();
            this.textBoxLinkIMG = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPortOmap = new System.IO.Ports.SerialPort(this.components);
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.progressBarPercent = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.Location = new System.Drawing.Point(444, 80);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(222, 320);
            this.textBoxLOG.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOpenPort);
            this.panel1.Controls.Add(this.comboBoxOmapCOM);
            this.panel1.Location = new System.Drawing.Point(9, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 104);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(13, 55);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(91, 28);
            this.buttonOpenPort.TabIndex = 6;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // comboBoxOmapCOM
            // 
            this.comboBoxOmapCOM.FormattingEnabled = true;
            this.comboBoxOmapCOM.Location = new System.Drawing.Point(13, 31);
            this.comboBoxOmapCOM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOmapCOM.Name = "comboBoxOmapCOM";
            this.comboBoxOmapCOM.Size = new System.Drawing.Size(92, 21);
            this.comboBoxOmapCOM.TabIndex = 2;
            this.comboBoxOmapCOM.Click += new System.EventHandler(this.comboBoxOmapCOM_Click);
            // 
            // textBoxLinkIMG
            // 
            this.textBoxLinkIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkIMG.Location = new System.Drawing.Point(9, 30);
            this.textBoxLinkIMG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLinkIMG.Name = "textBoxLinkIMG";
            this.textBoxLinkIMG.Size = new System.Drawing.Size(569, 23);
            this.textBoxLinkIMG.TabIndex = 12;
            this.textBoxLinkIMG.Text = "C:\\Users\\tranvantoan\\Desktop\\bg2.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 921600;
            this.serialPortOmap.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortOmap_ErrorReceived);
            this.serialPortOmap.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPortOmap_PinChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(582, 24);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(84, 34);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(10, 215);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(138, 43);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // progressBarPercent
            // 
            this.progressBarPercent.Location = new System.Drawing.Point(9, 414);
            this.progressBarPercent.Maximum = 320;
            this.progressBarPercent.Name = "progressBarPercent";
            this.progressBarPercent.Size = new System.Drawing.Size(657, 23);
            this.progressBarPercent.TabIndex = 17;
            // 
            // ImageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.Controls.Add(this.progressBarPercent);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLinkIMG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageSender";
            this.Text = "ImageSender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageSender_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLOG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.ComboBox comboBoxOmapCOM;
        private System.Windows.Forms.TextBox textBoxLinkIMG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPortOmap;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ProgressBar progressBarPercent;
    }
}