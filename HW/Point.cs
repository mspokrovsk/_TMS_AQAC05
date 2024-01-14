using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Point<T>
    {
        private T x, y;

        // Конструктор с 2 параметрами
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойства доступа к внутренним полям класса
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод, выводящий значения внутренних полей класса
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", x, y);
        }
    }
}
