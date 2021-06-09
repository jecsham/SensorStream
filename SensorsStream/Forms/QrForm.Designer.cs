
namespace SensorStream.Forms
{
    partial class QrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QrForm));
            this.qrCodepictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodepictureBox
            // 
            this.qrCodepictureBox.Location = new System.Drawing.Point(12, 12);
            this.qrCodepictureBox.Name = "qrCodepictureBox";
            this.qrCodepictureBox.Size = new System.Drawing.Size(96, 74);
            this.qrCodepictureBox.TabIndex = 0;
            this.qrCodepictureBox.TabStop = false;
            this.qrCodepictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 98);
            this.Controls.Add(this.qrCodepictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QrForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCodepictureBox;
    }
}