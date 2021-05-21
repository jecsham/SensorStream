using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsStream.Transports
{
    class TransportSettings
    {
        public bool IsUDPEnabled { get; set; }
        public int UDPPort { get; set; }
        public bool IsWSEnabled { get; set; }
        public int WSPort { get; set; }
    }
}
