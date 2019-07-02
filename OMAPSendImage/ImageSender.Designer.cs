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
            this.textBoxLinkIMG = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPortOmap = new System.IO.Ports.SerialPort(this.components);
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.progressBarPercent = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSystemTracking = new System.Windows.Forms.Label();
            this.timerTracking = new System.Windows.Forms.Timer(this.components);
            this.labelMoreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.Location = new System.Drawing.Point(442, 62);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(279, 449);
            this.textBoxLOG.TabIndex = 14;
            // 
            // textBoxLinkIMG
            // 
            this.textBoxLinkIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkIMG.Location = new System.Drawing.Point(9, 95);
            this.textBoxLinkIMG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLinkIMG.Name = "textBoxLinkIMG";
            this.textBoxLinkIMG.Size = new System.Drawing.Size(359, 22);
            this.textBoxLinkIMG.TabIndex = 12;
            this.textBoxLinkIMG.Text = "C:\\Users\\tranvantoan\\Desktop\\bg2.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(73, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 115200;
            this.serialPortOmap.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortOmap_ErrorReceived);
            this.serialPortOmap.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPortOmap_PinChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(9, 121);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(85, 34);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(73, 500);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(240, 43);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // progressBarPercent
            // 
            this.progressBarPercent.Location = new System.Drawing.Point(9, 564);
            this.progressBarPercent.Maximum = 320;
            this.progressBarPercent.Name = "progressBarPercent";
            this.progressBarPercent.Size = new System.Drawing.Size(375, 23);
            this.progressBarPercent.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Image File";
            // 
            // labelSystemTracking
            // 
            this.labelSystemTracking.AutoSize = true;
            this.labelSystemTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemTracking.ForeColor = System.Drawing.Color.Olive;
            this.labelSystemTracking.Location = new System.Drawing.Point(13, 13);
            this.labelSystemTracking.Name = "labelSystemTracking";
            this.labelSystemTracking.Size = new System.Drawing.Size(185, 29);
            this.labelSystemTracking.TabIndex = 20;
            this.labelSystemTracking.Text = "Finding deveice";
            // 
            // timerTracking
            // 
            this.timerTracking.Enabled = true;
            this.timerTracking.Interval = 1000;
            this.timerTracking.Tick += new System.EventHandler(this.timerTracking_Tick);
            // 
            // labelMoreInfo
            // 
            this.labelMoreInfo.AutoSize = true;
            this.labelMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreInfo.Location = new System.Drawing.Point(24, 49);
            this.labelMoreInfo.Name = "labelMoreInfo";
            this.labelMoreInfo.Size = new System.Drawing.Size(45, 16);
            this.labelMoreInfo.TabIndex = 21;
            this.labelMoreInfo.Text = "label1";
            // 
            // ImageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 599);
            this.Controls.Add(this.labelMoreInfo);
            this.Controls.Add(this.labelSystemTracking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarPercent);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.textBoxLinkIMG);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImageSender";
            this.Text = "ImageSender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageSender_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLOG;
        private System.Windows.Forms.TextBox textBoxLinkIMG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPortOmap;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ProgressBar progressBarPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSystemTracking;
        private System.Windows.Forms.Timer timerTracking;
        private System.Windows.Forms.Label labelMoreInfo;
    }
}