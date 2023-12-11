using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Bus : Transport
    {
        public Bus (string destination, int number, DateTime departureTime, int seats)
        {
            TransportType = KindOfTransport.Bus;
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            Seats = seats;
        }
        public override string GetTransportType()
        {
            return "Land";
        }
    }
}
