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
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLOG = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(262, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGetImage
            // 
            this.buttonGetImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetImage.ForeColor = System.Drawing.Color.White;
            this.buttonGetImage.Location = new System.Drawing.Point(15, 188);
            this.buttonGetImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetImage.Name = "buttonGetImage";
            this.buttonGetImage.Size = new System.Drawing.Size(225, 62);
            this.buttonGetImage.TabIndex = 1;
            this.buttonGetImage.Text = "Get Image";
            this.buttonGetImage.UseVisualStyleBackColor = false;
            this.buttonGetImage.Click += new System.EventHandler(this.buttonGetImage_Click);
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 115200;
            // 
            // comboBoxOmapCOM
            // 
            this.comboBoxOmapCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOmapCOM.FormattingEnabled = true;
            this.comboBoxOmapCOM.Location = new System.Drawing.Point(18, 43);
            this.comboBoxOmapCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOmapCOM.Name = "comboBoxOmapCOM";
            this.comboBoxOmapCOM.Size = new System.Drawing.Size(179, 28);
            this.comboBoxOmapCOM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // buttonSendImage
            // 
            this.buttonSendImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSendImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendImage.ForeColor = System.Drawing.Color.White;
            this.buttonSendImage.Location = new System.Drawing.Point(15, 274);
            this.buttonSendImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendImage.Name = "buttonSendImage";
            this.buttonSendImage.Size = new System.Drawing.Size(225, 62);
            this.buttonSendImage.TabIndex = 4;
            this.buttonSendImage.Text = "Send Image";
            this.buttonSendImage.UseVisualStyleBackColor = false;
            this.buttonSendImage.Click += new System.EventHandler(this.buttonSendImage_Click);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(18, 84);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(179, 38);
            this.buttonOpenPort.TabIndex = 6;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = false;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOpenPort);
            this.panel1.Controls.Add(this.comboBoxOmapCOM);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 144);
            this.panel1.TabIndex = 7;
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLOG.ForeColor = System.Drawing.Color.White;
            this.textBoxLOG.Location = new System.Drawing.Point(549, 28);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(300, 318);
            this.textBoxLOG.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(262, 356);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 41);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(859, 428);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSendImage);
            this.Controls.Add(this.buttonGetImage);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLOG;
        private System.Windows.Forms.Button buttonSave;
    }
}

