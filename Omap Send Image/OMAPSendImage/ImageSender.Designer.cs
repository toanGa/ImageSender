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
            this.buttonRun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.Location = new System.Drawing.Point(520, 99);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(272, 327);
            this.textBoxLOG.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOpenPort);
            this.panel1.Controls.Add(this.comboBoxOmapCOM);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 128);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(17, 68);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(121, 34);
            this.buttonOpenPort.TabIndex = 6;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // comboBoxOmapCOM
            // 
            this.comboBoxOmapCOM.FormattingEnabled = true;
            this.comboBoxOmapCOM.Location = new System.Drawing.Point(17, 38);
            this.comboBoxOmapCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOmapCOM.Name = "comboBoxOmapCOM";
            this.comboBoxOmapCOM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOmapCOM.TabIndex = 2;
            // 
            // textBoxLinkIMG
            // 
            this.textBoxLinkIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkIMG.Location = new System.Drawing.Point(12, 37);
            this.textBoxLinkIMG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLinkIMG.Name = "textBoxLinkIMG";
            this.textBoxLinkIMG.Size = new System.Drawing.Size(633, 27);
            this.textBoxLinkIMG.TabIndex = 12;
            this.textBoxLinkIMG.Text = "C:\\Users\\tranvantoan\\Desktop\\bg2.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(233, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 115200;
            this.serialPortOmap.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortOmap_DataReceived);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(680, 35);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 29);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(13, 265);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(184, 53);
            this.buttonRun.TabIndex = 16;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // ImageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 440);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLinkIMG);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageSender";
            this.Text = "ImageSender";
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
        private System.Windows.Forms.Button buttonRun;
    }
}