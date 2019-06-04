namespace OMAPSendImage
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGetImage = new System.Windows.Forms.Button();
            this.serialPortOmap = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxOmapCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendImage = new System.Windows.Forms.Button();
            this.textBoxLinkIMG = new System.Windows.Forms.TextBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLOG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(195, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGetImage
            // 
            this.buttonGetImage.Location = new System.Drawing.Point(16, 120);
            this.buttonGetImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetImage.Name = "buttonGetImage";
            this.buttonGetImage.Size = new System.Drawing.Size(131, 50);
            this.buttonGetImage.TabIndex = 1;
            this.buttonGetImage.Text = "Get Image";
            this.buttonGetImage.UseVisualStyleBackColor = true;
            this.buttonGetImage.Click += new System.EventHandler(this.buttonGetImage_Click);
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 115200;
            // 
            // comboBoxOmapCOM
            // 
            this.comboBoxOmapCOM.FormattingEnabled = true;
            this.comboBoxOmapCOM.Location = new System.Drawing.Point(13, 31);
            this.comboBoxOmapCOM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOmapCOM.Name = "comboBoxOmapCOM";
            this.comboBoxOmapCOM.Size = new System.Drawing.Size(92, 21);
            this.comboBoxOmapCOM.TabIndex = 2;
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
            // buttonSendImage
            // 
            this.buttonSendImage.Location = new System.Drawing.Point(16, 190);
            this.buttonSendImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendImage.Name = "buttonSendImage";
            this.buttonSendImage.Size = new System.Drawing.Size(131, 50);
            this.buttonSendImage.TabIndex = 4;
            this.buttonSendImage.Text = "Send Image";
            this.buttonSendImage.UseVisualStyleBackColor = true;
            this.buttonSendImage.Click += new System.EventHandler(this.buttonSendImage_Click);
            // 
            // textBoxLinkIMG
            // 
            this.textBoxLinkIMG.Location = new System.Drawing.Point(195, 30);
            this.textBoxLinkIMG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLinkIMG.Name = "textBoxLinkIMG";
            this.textBoxLinkIMG.Size = new System.Drawing.Size(181, 20);
            this.textBoxLinkIMG.TabIndex = 5;
            this.textBoxLinkIMG.Text = "C:\\Users\\tranvantoan\\Desktop\\bg2.png";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOpenPort);
            this.panel1.Controls.Add(this.comboBoxOmapCOM);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 92);
            this.panel1.TabIndex = 7;
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.Location = new System.Drawing.Point(410, 65);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(205, 259);
            this.textBoxLOG.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 354);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLinkIMG);
            this.Controls.Add(this.buttonSendImage);
            this.Controls.Add(this.buttonGetImage);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGetImage;
        private System.IO.Ports.SerialPort serialPortOmap;
        private System.Windows.Forms.ComboBox comboBoxOmapCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendImage;
        private System.Windows.Forms.TextBox textBoxLinkIMG;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLOG;
    }
}

