using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class TransportService
    {
        public void PrintTransportType(Transport transport)
        {
            Console.WriteLine(transport.GetTransportType());
        }
    }
}
