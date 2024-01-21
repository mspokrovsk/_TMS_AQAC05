using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 10 }; //инициализация массива numbers целыми числами

        var result = (from n in numbers //объявление переменной из массива
                      where n % 2 != 0 //фильтр нечетных чисел
                      select n).Distinct().ToList(); //Вызов метода Distinct для удаления повторяющихся элементов и преобразование результата в список с помощью метода ToList

        Console.WriteLine(string.Join(" ", result)); //вывод результата в консоль с помощью метода Join класса string, который соединяет элементы списка с помощью пробела.
    }
}
