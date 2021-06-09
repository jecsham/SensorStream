namespace SensorStream.Transports
{
    class TransportSettings
    {
        public bool IsUDPEnabled { get; set; }
        public int UDPPort { get; set; }
        public bool IsWSEnabled { get; set; }
        public int WSPort { get; set; }
    }
}
