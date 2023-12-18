using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Abstract
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea(); // Абстрактный метод для расчета площади
        public abstract double CalculatePerimeter(); // Абстрактный метод для расчета периметра
    }
}
