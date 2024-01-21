using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var clients = new[] { //инициализация массива clients анонимными объектами, содержащими информацию о клиентах фитнес-центра
            new { ClientCode = 1, Year = 2022, Month = 1, Duration = 10 },
            new { ClientCode = 2, Year = 2022, Month = 2, Duration = 5 },
            new { ClientCode = 3, Year = 2022, Month = 3, Duration = 7 },
            new { ClientCode = 4, Year = 2022, Month = 4, Duration = 5 },
            new { ClientCode = 5, Year = 2022, Month = 5, Duration = 5 },
            new { ClientCode = 6, Year = 2022, Month = 6, Duration = 3 },
            new { ClientCode = 7, Year = 2022, Month = 7, Duration = 5 },
            new { ClientCode = 8, Year = 2022, Month = 8, Duration = 2 },
            new { ClientCode = 9, Year = 2022, Month = 9, Duration = 5 },
            new { ClientCode = 10, Year = 2022, Month = 10, Duration = 4 },
            new { ClientCode = 11, Year = 2022, Month = 11, Duration = 5 },
            new { ClientCode = 12, Year = 2022, Month = 12, Duration = 1 },
            new { ClientCode = 13, Year = 2023, Month = 1, Duration = 5 },
            new { ClientCode = 14, Year = 2023, Month = 2, Duration = 3 },
            new { ClientCode = 15, Year = 2023, Month = 3, Duration = 2 },
            new { ClientCode = 16, Year = 2023, Month = 4, Duration = 5 },
            new { ClientCode = 17, Year = 2023, Month = 5, Duration = 5 },
            new { ClientCode = 18, Year = 2023, Month = 6, Duration = 6 },
            new { ClientCode = 19, Year = 2023, Month = 7, Duration = 5 },
            new { ClientCode = 20, Year = 2023, Month = 8, Duration = 4 },
            new { ClientCode = 21, Year = 2023, Month = 9, Duration = 5 },
            new { ClientCode = 22, Year = 2023, Month = 10, Duration = 3 },
            new { ClientCode = 23, Year = 2023, Month = 11, Duration = 5 },
            new { ClientCode = 24, Year = 2023, Month = 12, Duration = 1 }
        };

        var results = (from c in clients //создание переменной result с типом анонимного объекта, которая содержит информацию о клиенте с минимальной продолжительностью занятий
                      where c.Duration == clients.Min(x => x.Duration) //фильтрация элементов массива clients с помощью оператора where, который выбирает элементы с минимальной продолжительностью занятий
                      select new { c.Duration, c.Year, c.Month }); //операция проекции с выборкой необходимых полей из элементов массива clients
        foreach (var result in results) //цикл, который выводит на экран информацию о клиентах с минимальной продолжительностью занятий
        {
            Console.WriteLine($"{result.Duration} {result.Year} {result.Month}");
        }

        var lastResult = results.Last(); //создание переменной lastResult, которая содержит информацию о последнем клиенте с минимальной продолжительностью занятий в исходной последовательности

        Console.WriteLine($"{lastResult.Duration} {lastResult.Year} {lastResult.Month}"); //вывод информации о последнем клиенте с минимальной продолжительностью занятий в исходной последовательности
    }
}
