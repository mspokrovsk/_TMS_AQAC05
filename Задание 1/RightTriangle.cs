using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class RightTriangle : Triangle // Класс для подсчёта площади прямоугольного треугольника
    {
        public override void Area()
        {
            double area = 0.5 * (SideA * SideB);
            Console.WriteLine("Площадь прямоугольного треугольника: " + area);
        }
    }
}
