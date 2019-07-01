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
            this.textBoxFoderSaveImage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(196, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonGetImage.Location = new System.Drawing.Point(11, 203);
            this.buttonGetImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetImage.Name = "buttonGetImage";
            this.buttonGetImage.Size = new System.Drawing.Size(169, 50);
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
            this.comboBoxOmapCOM.Location = new System.Drawing.Point(14, 35);
            this.comboBoxOmapCOM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOmapCOM.Name = "comboBoxOmapCOM";
            this.comboBoxOmapCOM.Size = new System.Drawing.Size(135, 25);
            this.comboBoxOmapCOM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // buttonSendImage
            // 
            this.buttonSendImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSendImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendImage.ForeColor = System.Drawing.Color.White;
            this.buttonSendImage.Location = new System.Drawing.Point(11, 273);
            this.buttonSendImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendImage.Name = "buttonSendImage";
            this.buttonSendImage.Size = new System.Drawing.Size(169, 50);
            this.buttonSendImage.TabIndex = 4;
            this.buttonSendImage.Text = "Send Image Tool";
            this.buttonSendImage.UseVisualStyleBackColor = false;
            this.buttonSendImage.Click += new System.EventHandler(this.buttonSendImage_Click);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(14, 68);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(134, 31);
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
            this.panel1.Location = new System.Drawing.Point(9, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 117);
            this.panel1.TabIndex = 7;
            // 
            // textBoxLOG
            // 
            this.textBoxLOG.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLOG.ForeColor = System.Drawing.Color.White;
            this.textBoxLOG.Location = new System.Drawing.Point(459, 82);
            this.textBoxLOG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLOG.Multiline = true;
            this.textBoxLOG.Name = "textBoxLOG";
            this.textBoxLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLOG.Size = new System.Drawing.Size(331, 320);
            this.textBoxLOG.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(196, 415);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 33);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFoderSaveImage
            // 
            this.textBoxFoderSaveImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxFoderSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoderSaveImage.ForeColor = System.Drawing.Color.White;
            this.textBoxFoderSaveImage.Location = new System.Drawing.Point(196, 40);
            this.textBoxFoderSaveImage.Name = "textBoxFoderSaveImage";
            this.textBoxFoderSaveImage.Size = new System.Drawing.Size(480, 22);
            this.textBoxFoderSaveImage.TabIndex = 10;
            this.textBoxFoderSaveImage.Text = "Image Omap";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(681, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Foder Save Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFoderSaveImage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLOG);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLOG;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFoderSaveImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

