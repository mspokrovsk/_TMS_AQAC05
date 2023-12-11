using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class IsoscelesTriangle : Triangle // Класс для подсчёта площади равнобедренного треугольника
    {
        public override void Area()
        {
            double height = Math.Sqrt(SideA * SideA - (SideC * SideC / 4));
            Console.WriteLine("Площадь равнобедренного треугольника: " + ((SideC * height) / 2));
        }
    }
}
