using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    // Базовый класс врача
    public class Doctor
    {
        // Метод лечения
        public virtual void Heal()
        {
            Console.WriteLine("Врач лечит пациента");
        }
    }
}
