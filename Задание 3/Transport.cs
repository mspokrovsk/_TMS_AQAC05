using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Transport
    {
        public string Destination { get; set; }
        public int Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public int Seats { get; set; }
        public enum KindOfTransport { Bus, Train, Trolleybus};
        public KindOfTransport TransportType { get; set; }

        public virtual string GetTransportType()
        {
            return "Undefined";
        }

         string GetTransportTypeFixed()
        {
            return "FixedTransportType";
        }
    }
}
