using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace SensorStream.Forms
{
    public partial class QrForm : Form
    {
        private QRCodeGenerator qRCodeGenerator;
        private QRCodeData qRCodeData;
        private QRCode qRCode;
        private int pixelsPerModule = 5;
        public QrForm()
        {
            InitializeComponent();
        }

        public void GenerateQRCode(string qrData)
        {
            qRCodeGenerator = new QRCodeGenerator();
            qRCodeData = qRCodeGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            qRCode = new QRCode(qRCodeData);
            genQr();
        }

        private void genQr()
        {
            if (pixelsPerModule == 1)
            {
                buttonRemoveSize.Enabled = false;
            }
            else
            {
                buttonRemoveSize.Enabled = true;
            }

            if(pixelsPerModule == 20)
            {
                buttonAddSize.Enabled = false;
            } else
            {
                buttonAddSize.Enabled = true;
            }

            Bitmap graphic = qRCode.GetGraphic(pixelsPerModule);
            var size = new Size(graphic.Size.Width, graphic.Size.Height);
            qrCodepictureBox.Top = 35;
            qrCodepictureBox.Left = 0;
            qrCodepictureBox.Image = graphic;
            qrCodepictureBox.Size = size;
            this.ClientSize = new Size(qrCodepictureBox.Size.Width, qrCodepictureBox.Size.Height + 35);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void QrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void buttonAddSize_Click(object sender, EventArgs e)
        {
            pixelsPerModule += 1;
            genQr();
        }

        private void buttonRemoveSize_Click(object sender, EventArgs e)
        {
            pixelsPerModule -= 1;
            genQr();
        }
    }
}
