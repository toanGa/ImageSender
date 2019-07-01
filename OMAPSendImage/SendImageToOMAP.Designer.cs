namespace OMAPSendImage
{
    partial class SendImageToOMAP
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
            this.serialPortOmap = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // serialPortOmap
            // 
            this.serialPortOmap.BaudRate = 115200;
            // 
            // SendImageToOMAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SendImageToOMAP";
            this.Text = "SendImageToOMAP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortOmap;
    }
}