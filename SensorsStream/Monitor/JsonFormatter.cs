using System.Collections.Generic;
using Newtonsoft.Json;

namespace SensorStream.Monitor
{

    public class Sensor
    {
        public string type { get; set; }
        public string name { get; set; }
        public float? value { get; set; }
    }

    public class HardwareContent
    {
        public string type { get; set; }
        public string name { get; set; }

        public IList<Sensor> sensors { get; set; }

    }

    public class Config
    {
        public string ip { get; set; }
        public float interval { get; set; }
        public ConfigTransport transport { get; set; }
        public ConfigHardware hardware { get; set; }
    }

    public class ConfigTransport
    {
        public ConfigTransportInfo ws { get; set; }
        public ConfigTransportInfo udp { get; set; }
    }

    public class ConfigTransportInfo
    {
        public int port { get; set; }
        public bool enabled { get; set; }
    }

    public class ConfigHardware
    {
        public bool cpu { get; set; }
        public bool gpu { get; set; }
        public bool ram { get; set; }
        public bool motherboard { get; set; }
        public bool fans { get; set; }
        public bool network { get; set; }
        public bool storage { get; set; }
    }
    class JsonFormatter
    {
        private List<HardwareContent> hardwareContents;
        private List<Sensor> sensors;
        private Config config;

        public JsonFormatter(bool useConfig = false)
        {
            if (!useConfig)
            {
                hardwareContents = new List<HardwareContent>();
                sensors = new List<Sensor>();
            }
        }

        public void FillSensors(string type, string name, float? value)
        {
            sensors.Add(new Sensor
            {
                type = type,
                name = name,
                value = value
            });
        }

        public void FillHardware(string type, string name)
        {
            hardwareContents.Add(new HardwareContent
            {
                type = type,
                name = name,
                sensors = sensors
            });
            sensors = new List<Sensor>();
        }

        public string GetSerializedObject()
        {
            string json = JsonConvert.SerializeObject(hardwareContents);
            hardwareContents = new List<HardwareContent>();
            return json;
        }

        public string GetSerializedConfigObject(string ip, float interval, ConfigTransport configTransport, ConfigHardware configHardware)
        {
            config = new Config
            {
                ip = ip,
                interval = interval,
                transport = configTransport,
                hardware = configHardware
            };
            string json = JsonConvert.SerializeObject(config);
            return json;
        }
    }
}
