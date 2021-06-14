using System;
using System.Threading;
using System.Windows.Forms;

namespace SensorStream
{
    static class Program
    {
        private static Mutex mutex = null;
        [STAThread]
        static void Main()
        {
            const string appName = "com.jecsham.sensorstream";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("There is already an instance of Sensor Stream running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
