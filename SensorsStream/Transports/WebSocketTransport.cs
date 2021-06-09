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
                Console.WriteLine("Websocket Started");
                this.socket = socket;
                socket.OnOpen = () => allSockets.Add(socket);
                socket.OnClose = () =>
                {
                    //allSockets.Remove(socket);
                };
            });
        }

        public void sendMessage(string msg)
        {
            // broadcast
            foreach (var socket in allSockets)
            {
                if (socket != null)
                {
                    socket.Send(msg);
                }
            }
        }

        public void Stop()
        {
            server.Dispose();
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
