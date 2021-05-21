using System.Collections.Generic;
using Newtonsoft.Json;

namespace SensorsStream.Monitor
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
    class JsonFormatter
    {
        private List<HardwareContent> hardwareContents;
        private List<Sensor> sensors;

        public JsonFormatter()
        {
            hardwareContents = new List<HardwareContent>();
            sensors = new List<Sensor>();
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
    }
}
