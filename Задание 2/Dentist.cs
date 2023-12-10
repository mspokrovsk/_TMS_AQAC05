using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Dentist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Стоматолог лечит пациента");
        }
    }
}
