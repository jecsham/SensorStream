using System;
using Fleck;

namespace SensorsStream.Transports
{
    class WebSocketTransport : ITransport
    {
        private WebSocketServer server;
        private IWebSocketConnection socket;

        public WebSocketTransport(int port)
        {
            server = new WebSocketServer("ws://0.0.0.0:" + port);
            server.RestartAfterListenError = true;
        }
        public void Start()
        {
            server.Start(socket =>
            {
                Console.WriteLine("Websocket Started");
                this.socket = socket;
                socket.OnOpen = () => Console.WriteLine("Websocket Open");
                socket.OnClose = () => Console.WriteLine("Websocket Close");
            });
        }

        public void sendMessage(string msg)
        {
            if (socket != null)
            {
                socket.Send(msg);
            }
        }

        public void Stop()
        {
            server.Dispose();
            if (socket != null)
            {
                socket.Close();
            }
            Console.WriteLine("Websocket Stopped");
        }
    }
}
