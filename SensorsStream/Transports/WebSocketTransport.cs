using System;
using System.Collections.Generic;
using Fleck;

namespace SensorStream.Transports
{
    class WebSocketTransport : ITransport
    {
        private WebSocketServer server;
        private IWebSocketConnection socket;
        private IList<IWebSocketConnection> allSockets;
        public WebSocketTransport(int port)
        {
            server = new WebSocketServer("ws://0.0.0.0:" + port);
            server.RestartAfterListenError = true;
        }
        public void Start()
        {
            allSockets = new List<IWebSocketConnection>();
            server.Start(socket =>
            {
                Console.WriteLine("New socket");
                this.socket = socket;
                socket.OnOpen = () => allSockets.Add(socket);
                socket.OnClose = () => { };
            });
        }

        public void sendMessage(string msg)
        {
            // broadcast
            IWebSocketConnection deletableSocket = null;
            foreach (var socket in allSockets)
            {
                if (socket != null)
                {
                    if (socket.IsAvailable)
                    {
                        socket.Send(msg);
                    }
                    else
                    {
                        deletableSocket = socket;
                    }
                }
            }
            if (deletableSocket != null)
            {
                Console.WriteLine("Socket closed");
                allSockets.Remove(deletableSocket);
            }
        }

        public void Stop()
        {
            server.Dispose();

            for (int i = 0; i < allSockets.Count; i++)
            {
                allSockets[i].Close();
            }

            foreach (var socket in allSockets)
            {
                if (socket != null)
                {
                    socket.Close();
                }
            }
            Console.WriteLine("Websocket Stopped");
        }
    }
}
