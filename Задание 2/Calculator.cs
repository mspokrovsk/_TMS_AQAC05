using System;

namespace Задание_2
{
    public class Calculator
    {
        public double CalculateCircumference(double R) //метод вычисления длины окружности, который принимает на вход переменную типа double и возвращает значение типа double
        {
            return 2 * Math.PI * R;
        }

        public double CalculateArea(double R) //метод вычисления площади круга, который принимает на вход переменную типа double и возвращает значение типа double
        {
            return Math.PI * R * R;
        }

        public double CalculateVolume(double R) //метод вычисления объема шара, который принимает на вход переменную типа double и возвращает значение типа double
        {
            return 4.0 / 3.0 * Math.PI * R * R * R;
        }
    }
}
