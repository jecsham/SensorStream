namespace SensorStream.Transports
{
    interface ITransport
    {
        void Start();
        void Stop();
        void sendMessage(string msg);
    }
}
