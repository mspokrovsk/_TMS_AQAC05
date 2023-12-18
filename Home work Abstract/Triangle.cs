using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public class Triangle : Shape
    {
        private double side1, side2, side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public override double CalculateArea()
        {
            // Формула Герона для расчета площади треугольника
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3; // Периметр треугольника
        }
    }
}
