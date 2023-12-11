using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Rectangle : Shape // Класс для подсчёта площади прямоугольника
    {
        public override void Area()
        {
           double area =  Width * Height;
           Console.WriteLine("Площадь прямоугольника: " + area);

        }
    }
}
