

namespace SensorStream
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
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEnableWS = new System.Windows.Forms.CheckBox();
            this.textBoxPortWS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPortUDP = new System.Windows.Forms.TextBox();
            this.checkBoxEnableUDP = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableStorage = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableMother = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableNetwork = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableFansCtrlers = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableRAM = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableGPU = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableCPU = new System.Windows.Forms.CheckBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRunOnStartup = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(182, 381);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textBoxInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxRunOnStartup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Location = new System.Drawing.Point(6, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(233, 100);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transports";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.checkBoxEnableWS);
            this.groupBox3.Controls.Add(this.textBoxPortWS);
            this.groupBox3.Location = new System.Drawing.Point(113, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WebSocket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port:";
            // 
            // checkBoxEnableWS
            // 
            this.checkBoxEnableWS.AutoSize = true;
            this.checkBoxEnableWS.Checked = true;
            this.checkBoxEnableWS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableWS.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnableWS.Name = "checkBoxEnableWS";
            this.checkBoxEnableWS.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEnableWS.TabIndex = 3;
            this.checkBoxEnableWS.Text = "Enable";
            this.checkBoxEnableWS.UseVisualStyleBackColor = true;
            // 
            // textBoxPortWS
            // 
            this.textBoxPortWS.Location = new System.Drawing.Point(38, 37);
            this.textBoxPortWS.Name = "textBoxPortWS";
            this.textBoxPortWS.Size = new System.Drawing.Size(54, 20);
            this.textBoxPortWS.TabIndex = 3;
            this.textBoxPortWS.Text = "8546";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPortUDP);
            this.groupBox2.Controls.Add(this.checkBoxEnableUDP);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UDP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // textBoxPortUDP
            // 
            this.textBoxPortUDP.Location = new System.Drawing.Point(38, 37);
            this.textBoxPortUDP.Name = "textBoxPortUDP";
            this.textBoxPortUDP.Size = new System.Drawing.Size(54, 20);
            this.textBoxPortUDP.TabIndex = 1;
            this.textBoxPortUDP.Text = "8545";
            // 
            // checkBoxEnableUDP
            // 
            this.checkBoxEnableUDP.AutoSize = true;
            this.checkBoxEnableUDP.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnableUDP.Name = "checkBoxEnableUDP";
            this.checkBoxEnableUDP.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEnableUDP.TabIndex = 0;
            this.checkBoxEnableUDP.Text = "Enable";
            this.checkBoxEnableUDP.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxEnableStorage);
            this.groupBox4.Controls.Add(this.checkBoxEnableMother);
            this.groupBox4.Controls.Add(this.checkBoxEnableNetwork);
            this.groupBox4.Controls.Add(this.checkBoxEnableFansCtrlers);
            this.groupBox4.Controls.Add(this.checkBoxEnableRAM);
            this.groupBox4.Controls.Add(this.checkBoxEnableGPU);
            this.groupBox4.Controls.Add(this.checkBoxEnableCPU);
            this.groupBox4.Location = new System.Drawing.Point(6, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 90);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hardware";
            // 
            // checkBoxEnableStorage
            // 
            this.checkBoxEnableStorage.AutoSize = true;
            this.checkBoxEnableStorage.Location = new System.Drawing.Point(153, 20);
            this.checkBoxEnableStorage.Name = "checkBoxEnableStorage";
            this.checkBoxEnableStorage.Size = new System.Drawing.Size(63, 17);
            this.checkBoxEnableStorage.TabIndex = 6;
            this.checkBoxEnableStorage.Text = "Storage";
            this.checkBoxEnableStorage.UseVisualStyleBackColor = true;
            this.checkBoxEnableStorage.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxEnableMother
            // 
            this.checkBoxEnableMother.AutoSize = true;
            this.checkBoxEnableMother.Location = new System.Drawing.Point(61, 20);
            this.checkBoxEnableMother.Name = "checkBoxEnableMother";
            this.checkBoxEnableMother.Size = new System.Drawing.Size(86, 17);
            this.checkBoxEnableMother.TabIndex = 5;
            this.checkBoxEnableMother.Text = "Motherboard";
            this.checkBoxEnableMother.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableNetwork
            // 
            this.checkBoxEnableNetwork.AutoSize = true;
            this.checkBoxEnableNetwork.Location = new System.Drawing.Point(61, 68);
            this.checkBoxEnableNetwork.Name = "checkBoxEnableNetwork";
            this.checkBoxEnableNetwork.Size = new System.Drawing.Size(66, 17);
            this.checkBoxEnableNetwork.TabIndex = 4;
            this.checkBoxEnableNetwork.Text = "Network";
            this.checkBoxEnableNetwork.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableFansCtrlers
            // 
            this.checkBoxEnableFansCtrlers.AutoSize = true;
            this.checkBoxEnableFansCtrlers.Location = new System.Drawing.Point(61, 44);
            this.checkBoxEnableFansCtrlers.Name = "checkBoxEnableFansCtrlers";
            this.checkBoxEnableFansCtrlers.Size = new System.Drawing.Size(49, 17);
            this.checkBoxEnableFansCtrlers.TabIndex = 3;
            this.checkBoxEnableFansCtrlers.Text = "Fans";
            this.checkBoxEnableFansCtrlers.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableRAM
            // 
            this.checkBoxEnableRAM.AutoSize = true;
            this.checkBoxEnableRAM.Location = new System.Drawing.Point(7, 68);
            this.checkBoxEnableRAM.Name = "checkBoxEnableRAM";
            this.checkBoxEnableRAM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxEnableRAM.TabIndex = 2;
            this.checkBoxEnableRAM.Text = "RAM";
            this.checkBoxEnableRAM.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableGPU
            // 
            this.checkBoxEnableGPU.AutoSize = true;
            this.checkBoxEnableGPU.Checked = true;
            this.checkBoxEnableGPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableGPU.Location = new System.Drawing.Point(7, 44);
            this.checkBoxEnableGPU.Name = "checkBoxEnableGPU";
            this.checkBoxEnableGPU.Size = new System.Drawing.Size(49, 17);
            this.checkBoxEnableGPU.TabIndex = 1;
            this.checkBoxEnableGPU.Text = "GPU";
            this.checkBoxEnableGPU.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableCPU
            // 
            this.checkBoxEnableCPU.AutoSize = true;
            this.checkBoxEnableCPU.Checked = true;
            this.checkBoxEnableCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableCPU.Location = new System.Drawing.Point(7, 20);
            this.checkBoxEnableCPU.Name = "checkBoxEnableCPU";
            this.checkBoxEnableCPU.Size = new System.Drawing.Size(48, 17);
            this.checkBoxEnableCPU.TabIndex = 0;
            this.checkBoxEnableCPU.Text = "CPU";
            this.checkBoxEnableCPU.UseVisualStyleBackColor = true;
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(99, 39);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(33, 20);
            this.textBoxInterval.TabIndex = 2;
            this.textBoxInterval.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval (seconds):";
            // 
            // checkBoxRunOnStartup
            // 
            this.checkBoxRunOnStartup.AutoSize = true;
            this.checkBoxRunOnStartup.Location = new System.Drawing.Point(9, 19);
            this.checkBoxRunOnStartup.Name = "checkBoxRunOnStartup";
            this.checkBoxRunOnStartup.Size = new System.Drawing.Size(147, 17);
            this.checkBoxRunOnStartup.TabIndex = 0;
            this.checkBoxRunOnStartup.Text = "Run On Windows Startup";
            this.checkBoxRunOnStartup.UseVisualStyleBackColor = true;
            this.checkBoxRunOnStartup.CheckedChanged += new System.EventHandler(this.checkBoxRunOnStartup_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelStatus);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.buttonCopy);
            this.groupBox5.Controls.Add(this.textBoxIP);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(9, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 83);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Service Info";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(52, 36);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Stopped";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "QR Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(170, 11);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(61, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Enabled = false;
            this.textBoxIP.Location = new System.Drawing.Point(61, 13);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ReadOnly = true;
            this.textBoxIP.Size = new System.Drawing.Size(103, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Local IP:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sensors Stream";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemStart,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 92);
            this.contextMenuStrip.Text = "Options";
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemShow.Text = "Show";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItemStart.Text = "Start";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.toolStripMenuItemStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 416);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPortUDP;
        private System.Windows.Forms.CheckBox checkBoxEnableUDP;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRunOnStartup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxEnableWS;
        private System.Windows.Forms.TextBox textBoxPortWS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxEnableNetwork;
        private System.Windows.Forms.CheckBox checkBoxEnableFansCtrlers;
        private System.Windows.Forms.CheckBox checkBoxEnableRAM;
        private System.Windows.Forms.CheckBox checkBoxEnableGPU;
        private System.Windows.Forms.CheckBox checkBoxEnableCPU;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.CheckBox checkBoxEnableMother;
        private System.Windows.Forms.CheckBox checkBoxEnableStorage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
    }
}

