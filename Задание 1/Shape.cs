using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Shape //класс для представления геометрических фигур
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public virtual void Area()
        {
            Console.WriteLine("Площадь равна: ");
        }
    }
}
