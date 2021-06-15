
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSize = new System.Windows.Forms.Button();
            this.buttonRemoveSize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodepictureBox
            // 
            this.qrCodepictureBox.Location = new System.Drawing.Point(12, 50);
            this.qrCodepictureBox.Name = "qrCodepictureBox";
            this.qrCodepictureBox.Size = new System.Drawing.Size(144, 74);
            this.qrCodepictureBox.TabIndex = 0;
            this.qrCodepictureBox.TabStop = false;
            this.qrCodepictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Size";
            // 
            // buttonAddSize
            // 
            this.buttonAddSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSize.Location = new System.Drawing.Point(98, 8);
            this.buttonAddSize.Name = "buttonAddSize";
            this.buttonAddSize.Size = new System.Drawing.Size(27, 23);
            this.buttonAddSize.TabIndex = 2;
            this.buttonAddSize.Text = "+";
            this.buttonAddSize.UseVisualStyleBackColor = true;
            this.buttonAddSize.Click += new System.EventHandler(this.buttonAddSize_Click);
            // 
            // buttonRemoveSize
            // 
            this.buttonRemoveSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSize.Location = new System.Drawing.Point(65, 8);
            this.buttonRemoveSize.Name = "buttonRemoveSize";
            this.buttonRemoveSize.Size = new System.Drawing.Size(27, 23);
            this.buttonRemoveSize.TabIndex = 3;
            this.buttonRemoveSize.Text = "-";
            this.buttonRemoveSize.UseVisualStyleBackColor = true;
            this.buttonRemoveSize.Click += new System.EventHandler(this.buttonRemoveSize_Click);
            // 
            // QrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 136);
            this.Controls.Add(this.buttonRemoveSize);
            this.Controls.Add(this.buttonAddSize);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCodepictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSize;
        private System.Windows.Forms.Button buttonRemoveSize;
    }
}