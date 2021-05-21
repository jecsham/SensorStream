using System;
using System.Collections.Generic;
using System.Threading;
using SensorsStream.Monitor;

namespace SensorsStream.Transports
{
    class Manager
    {
        private Stack<ITransport> transportInstances;
        private bool running;
        private HardwareMonitor monitor;
        private int interval;

        public Manager()
        {
        }

        public void Init(
            TransportSettings transportSettings,
            float interval,
            ComputerSettings computerSettings
            )
        {
            monitor = new HardwareMonitor(computerSettings);
            this.interval = (int)(interval * 1000);
            transportInstances = new Stack<ITransport>();
            // UDP
            if (transportSettings.IsUDPEnabled)
            {
                UdpTransport instance = new UdpTransport(transportSettings.UDPPort);
                instance.Start();
                transportInstances.Push(instance);
            }

            // WebSocket
            if (transportSettings.IsWSEnabled)
            {
                WebSocketTransport instance = new WebSocketTransport(transportSettings.WSPort);
                instance.Start();
                transportInstances.Push(instance);
            }
            InitBroadcaster();
        }

        private void InitBroadcaster()
        {

            Thread loopThread = new Thread(LoopThread);
            running = true;
            loopThread.Start();
            Console.WriteLine("Loop Thread Started");
        }

        private void LoopThread()
        {
            monitor.Open();
            while (running)
            {
                string componentsData = monitor.GetSystemData();
                //string componentsData = "test";
                foreach (ITransport c in transportInstances)
                {
                    c.sendMessage(componentsData);
                }

                Thread.Sleep(interval);
            }
            monitor.Close();
        }

        public void Finish()
        {
            running = false;
            foreach (ITransport c in transportInstances)
            {
                c.Stop();
            }
        }
    }
}
