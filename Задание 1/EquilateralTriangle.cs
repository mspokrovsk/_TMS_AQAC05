using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class EquilateralTriangle : Triangle // Класс для подсчёта площади равностороннего треугольника
    {
        public override void Area()
        {
            double area = (Math.Sqrt(3) / 4) * SideA * SideA;
            Console.WriteLine("Площадь равностороннего треугольника: " + area);
        }
    }
}
