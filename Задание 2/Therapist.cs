using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Therapist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Терапевт лечит пациента");
        }
    }
}
