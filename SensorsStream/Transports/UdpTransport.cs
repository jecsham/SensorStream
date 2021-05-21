using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SensorsStream.Transports
{
    class UdpTransport : ITransport
    {
        private int port;
        UdpClient udpServer;
        IPEndPoint remoteEP;

        public UdpTransport(int port)
        {
            this.port = port;
        }

        public void sendMessage(string msg)
        {
            byte[] msgByte = Encoding.UTF8.GetBytes(msg);
            udpServer.Send(msgByte, msgByte.Length, remoteEP);
        }

        public void Start()
        {
            udpServer = new UdpClient();
            remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            Console.WriteLine("UDP Channel started");
        }

        public void Stop()
        {
            Console.WriteLine("UDP Channel stopped");
            udpServer.Close();
        }

    }
}
