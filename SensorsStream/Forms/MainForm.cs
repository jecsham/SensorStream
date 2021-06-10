using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using SensorStream.Forms;
using SensorStream.Monitor;
using SensorStream.Transports;

namespace SensorStream
{
    public partial class Form1 : Form
    {
        private Manager channelManager;
        private bool servicesStarted;
        private QrForm qrCode;
        private bool qrCodeIsSwown = false;
        private readonly StartupManager startupManager;
        public Form1()
        {
            InitializeComponent();
            channelManager = new Manager();
            startupManager = new StartupManager();
            textBoxIP.Text = LocalIPAddress().ToString();
            LoadSettigns();
            qrCode = new QrForm();
            notifyIcon.Visible = true;
        }

        private IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!servicesStarted)
            {
                SetStatus(ServiceStatus.STARTING);
                bool[] enabledServcices = new bool[2];
                int[] prots = new int[2];
                bool[] enabledHardware = new bool[5];
                ComputerSettings computerSettings = new ComputerSettings();
                TransportSettings transportSettings = new TransportSettings();

                // Transports - 2
                transportSettings.IsUDPEnabled = checkBoxEnableUDP.Checked;
                transportSettings.IsWSEnabled = checkBoxEnableWS.Checked;

                // Hardware 
                computerSettings.IsCpuEnabled = checkBoxEnableCPU.Checked;
                computerSettings.IsGpuEnabled = checkBoxEnableGPU.Checked;
                computerSettings.IsMemoryEnabled = checkBoxEnableRAM.Checked;
                computerSettings.IsMotherboardEnabled = checkBoxEnableMother.Checked;
                computerSettings.IsControllerEnabled = checkBoxEnableFansCtrlers.Checked;
                computerSettings.IsNetworkEnabled = checkBoxEnableNetwork.Checked;
                computerSettings.IsStorageEnabled = checkBoxEnableStorage.Checked;

                if (ValidateForm())
                {
                    // Services ports - 2
                    transportSettings.UDPPort = int.Parse(textBoxPortUDP.Text);
                    transportSettings.WSPort = int.Parse(textBoxPortWS.Text);

                    float interval = float.Parse(textBoxInterval.Text);
                    channelManager.Init(
                        transportSettings,
                        interval,
                        computerSettings
                        );
                    servicesStarted = true;
                    SaveSettings();
                    SetStatus(ServiceStatus.STARTED);
                }
                else
                {
                    SetStatus(ServiceStatus.STOPPED);
                }
            }
            else
            {
                StopAll();
            }
        }

        private void StopAll()
        {
            SetStatus(ServiceStatus.STOPPING);
            servicesStarted = false;
            channelManager.Finish();
            buttonStartStop.Text = "Start";
            SetStatus(ServiceStatus.STOPPED);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxIP.Text);
        }

        private DialogResult ErrorDialog(string errorMsg)
        {
            return MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetStatus(ServiceStatus status)
        {
            switch (status)
            {
                case ServiceStatus.STARTING:
                    {
                        labelStatus.Text = "Starting...";
                        EnableUnsafeInputs(false);
                    }
                    break;
                case ServiceStatus.STARTED:
                    {
                        labelStatus.Text = "Running";
                        buttonStartStop.Text = "Stop";
                    }
                    break;
                case ServiceStatus.STOPPING:
                    {
                        labelStatus.Text = "Stopping";
                    }
                    break;
                case ServiceStatus.STOPPED:
                    {
                        labelStatus.Text = "Stopped";
                        buttonStartStop.Text = "Start";
                        EnableUnsafeInputs(true);
                    }
                    break;
                case ServiceStatus.ERROR:
                    {
                        labelStatus.Text = "An error ocurred. Please restart";
                        EnableUnsafeInputs(true);
                    }
                    break;
            }

        }

        private void EnableUnsafeInputs(bool enabled)
        {
            // transport checkboxes
            checkBoxEnableUDP.Enabled = enabled;
            checkBoxEnableWS.Enabled = enabled;

            // hardware checkboxes
            checkBoxEnableCPU.Enabled = enabled;
            checkBoxEnableGPU.Enabled = enabled;
            checkBoxEnableRAM.Enabled = enabled;
            checkBoxEnableFansCtrlers.Enabled = enabled;
            checkBoxEnableStorage.Enabled = enabled;
            checkBoxEnableMother.Enabled = enabled;
            checkBoxEnableNetwork.Enabled = enabled;

            // textboxes ports
            textBoxPortUDP.Enabled = enabled;
            textBoxPortWS.Enabled = enabled;

            // textbox interval
            textBoxInterval.Enabled = enabled;
        }

        private void LoadSettigns()
        {
            // Startup checkbox
            //checkBoxRunOnStartup.Checked = Properties.Settings.Default.RunOnStarup;
            checkBoxRunOnStartup.Checked = startupManager.Startup;

            // transport checkboxes
            checkBoxEnableUDP.Checked = Properties.Settings.Default.UDPTransport;
            checkBoxEnableWS.Checked = Properties.Settings.Default.WSTransport;

            // hardware checkboxes
            checkBoxEnableCPU.Checked = Properties.Settings.Default.CPUHardware;
            checkBoxEnableGPU.Checked = Properties.Settings.Default.GPUHardware;
            checkBoxEnableRAM.Checked = Properties.Settings.Default.RAMHardware;
            checkBoxEnableFansCtrlers.Checked = Properties.Settings.Default.FanHardware;
            checkBoxEnableStorage.Checked = Properties.Settings.Default.StorageHardware;
            checkBoxEnableMother.Checked = Properties.Settings.Default.MotherboardHardware;
            checkBoxEnableNetwork.Checked = Properties.Settings.Default.NetworkHardware;

            // textboxes ports
            textBoxPortUDP.Text = Properties.Settings.Default.UDPPort;
            textBoxPortWS.Text = Properties.Settings.Default.WSPort;

            // textbox interval
            textBoxInterval.Text = Properties.Settings.Default.Interval;
        }

        private void SaveSettings()
        {
            // Startup checkbox
            //Properties.Settings.Default.RunOnStarup = checkBoxRunOnStartup.Checked;

            // transport checkboxes
            Properties.Settings.Default.UDPTransport = checkBoxEnableUDP.Checked;
            Properties.Settings.Default.WSTransport = checkBoxEnableWS.Checked;

            // hardware checkboxes
            Properties.Settings.Default.CPUHardware = checkBoxEnableCPU.Checked;
            Properties.Settings.Default.GPUHardware = checkBoxEnableGPU.Checked;
            Properties.Settings.Default.RAMHardware = checkBoxEnableRAM.Checked;
            Properties.Settings.Default.FanHardware = checkBoxEnableFansCtrlers.Checked;
            Properties.Settings.Default.StorageHardware = checkBoxEnableStorage.Checked;
            Properties.Settings.Default.MotherboardHardware = checkBoxEnableMother.Checked;
            Properties.Settings.Default.NetworkHardware = checkBoxEnableNetwork.Checked;

            // textboxes ports
            Properties.Settings.Default.UDPPort = textBoxPortUDP.Text;
            Properties.Settings.Default.WSPort = textBoxPortWS.Text;

            // textbox interval
            Properties.Settings.Default.Interval = textBoxInterval.Text;
            Properties.Settings.Default.Save();
        }

        private bool ValidateForm()
        {
            // check checkbox services
            if (!(checkBoxEnableWS.Checked || checkBoxEnableUDP.Checked))
            {
                ErrorDialog("At least one Transport must be selected");
                return false;
            }

            // check ceckbox hardware
            if (!(checkBoxEnableCPU.Checked ||
                checkBoxEnableGPU.Checked ||
                checkBoxEnableRAM.Checked ||
                checkBoxEnableFansCtrlers.Checked ||
                checkBoxEnableStorage.Checked ||
                checkBoxEnableMother.Checked ||
                checkBoxEnableNetwork.Checked))
            {
                ErrorDialog("At least one Hardware must be selected");
                return false;
            }

            // check interval input
            if (float.TryParse(textBoxInterval.Text, out float interval))
            {
                if (interval < 0.49 || interval > int.MaxValue)
                {
                    ErrorDialog($"The interval number must be in the range of 0.5 and {int.MaxValue}");
                    return false;
                }

            }
            else
            {
                ErrorDialog($"The interval number is invalid. Must be in the range of 0.5 and {int.MaxValue}");
                return false;
            }

            // check ports inputs
            if (checkBoxEnableUDP.Checked)
            {
                if (int.TryParse(textBoxPortUDP.Text, out int port))
                {
                    if (port > 65535 || port < 1023)
                    {
                        ErrorDialog($"Port for UDP Transport must be in the range of 1024 and 65535");
                        return false;
                    }
                }
                else
                {
                    ErrorDialog($"Port for UDP Transport is invalid. Must be in the range of 1024 and 65535");
                    return false;
                }
            }

            if (checkBoxEnableWS.Checked)
            {
                if (int.TryParse(textBoxPortWS.Text, out int port))
                {
                    if (port > 65535 || port < 1023)
                    {
                        ErrorDialog($"Port for WebSocket Transport must be in the range of 1024 and 65535");
                        return false;
                    }
                }
                else
                {
                    ErrorDialog($"Port for WebSocket Transport is invalid. Must be in the range of 1024 and 65535");
                    return false;
                }
            }

            return true;
        }

        private void checkBoxRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                startupManager.Startup = checkBoxRunOnStartup.Checked;
                //Properties.Settings.Default.RunOnStarup = checkBoxRunOnStartup.Checked;
                //Properties.Settings.Default.Save();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Updating the auto-startup option failed.", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxRunOnStartup.Checked = false;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (qrCodeIsSwown)
            {
                qrCode.Hide();
                qrCodeIsSwown = false;
            }
            else
            {
                string qrData = "{ \"ip\":\"" + textBoxIP.Text + "\",\"ports\":{\"ws\":" + textBoxPortWS.Text + ",\"udp\":" + textBoxPortUDP.Text + " } }"; // {3}
                qrCode.Top = this.Top;
                qrCode.Left = this.Right - 14;
                qrCode.GenerateQRCode(qrData);
                qrCode.Show();
                qrCodeIsSwown = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servicesStarted)
            {
                StopAll();
            }
        }
    }
}
