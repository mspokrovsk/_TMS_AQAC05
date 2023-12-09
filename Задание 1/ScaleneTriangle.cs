using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class ScaleneTriangle : Triangle // Класс для подсчёта площади разностороннего треугольника
    {
        public override void Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            Console.WriteLine("Площадь разностороннего треугольника: " + Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)));
        }
    }
}
