using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // Площадь круга
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius; // Периметр круга
        }
    }
}
