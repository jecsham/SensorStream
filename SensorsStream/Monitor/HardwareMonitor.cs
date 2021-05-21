using LibreHardwareMonitor.Hardware;

namespace SensorsStream.Monitor
{
    public class HardwareMonitor
    {
        private Computer computer;
        private JsonFormatter jsonFormatter;
        public HardwareMonitor(ComputerSettings computerSettings)
        {
            computer = new Computer
            {
                IsCpuEnabled = computerSettings.IsCpuEnabled,
                IsGpuEnabled = computerSettings.IsGpuEnabled,
                IsMemoryEnabled = computerSettings.IsMemoryEnabled,
                IsMotherboardEnabled = computerSettings.IsMotherboardEnabled,
                IsControllerEnabled = computerSettings.IsControllerEnabled,
                IsNetworkEnabled = computerSettings.IsNetworkEnabled,
                IsStorageEnabled = computerSettings.IsStorageEnabled
            };
            jsonFormatter = new JsonFormatter();
        }

        public void Open()
        {
            computer.Open();
        }

        public void Close()
        {
            computer.Close();
        }

        public string GetSystemData()
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    // fill sensors 
                    jsonFormatter.FillSensors(sensor.SensorType.ToString(), sensor.Name, sensor.Value);
                }
                // fill hardwareContent
                jsonFormatter.FillHardware(hardware.HardwareType.ToString(), hardware.Name);
            }
            return jsonFormatter.GetSerializedObject();
        }
    }
}

