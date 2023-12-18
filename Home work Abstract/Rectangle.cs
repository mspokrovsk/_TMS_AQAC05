using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double CalculateArea()
        {
            return length * width; // Площадь прямоугольника
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width); // Периметр прямоугольника
        }
    }
}
