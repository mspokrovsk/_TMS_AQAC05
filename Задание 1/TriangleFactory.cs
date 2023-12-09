using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class TriangleFactory // Класс для логики создания треугольников
    {
        public static Shape CreateTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA == sideB && sideB == sideC) // Равносторонний
            {
                return new EquilateralTriangle { SideA = sideA, SideB = sideB, SideC = sideC };
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC) // Равнобедренный
            {
                return new IsoscelesTriangle { SideA = sideA, SideB = sideB, SideC = sideC };
            }
            else if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) // прямоугольный
            {
                return new RightTriangle { SideA = sideA, SideB = sideB, SideC = sideC };
            }
            else // Разносторонний
            {
                return new ScaleneTriangle { SideA = sideA, SideB = sideB, SideC = sideC };
            }
        }
    }
}
