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
        public QrForm()
        {
            InitializeComponent();
        }

        public void GenerateQRCode(string qrData)
        {
            qRCodeGenerator = new QRCodeGenerator();
            qRCodeData = qRCodeGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            qRCode = new QRCode(qRCodeData);
            Bitmap graphic = qRCode.GetGraphic(7);
            var size = new Size(graphic.Size.Width, graphic.Size.Height);
            qrCodepictureBox.Top = 0;
            qrCodepictureBox.Left = 0;
            qrCodepictureBox.Image = graphic;
            qrCodepictureBox.Size = size;
            this.ClientSize = new Size(qrCodepictureBox.Size.Width, qrCodepictureBox.Size.Height);
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
    }
}
