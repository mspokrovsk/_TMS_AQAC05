using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Square : Rectangle // Класс для подсчёта площади квадрата
    {
        public override void Area()
        {
            double area = Width * Width;
            Console.WriteLine("Площадь квадрата: " + area);
        }
    }
}
