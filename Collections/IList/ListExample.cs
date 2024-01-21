using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    {
        // Создаем список строк
        List<string> stringList = new List<string>();
        List<string> stringList1 = new List<string>(16);
        Console.WriteLine($"Capacity1 : {stringList.Capacity}");
        Console.WriteLine($"Capacity2 : {stringList1.Capacity}");

        // Добавление элементов
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");
        stringList.AddRange(new string[] { "Test", "Test1", "Test2" });

        // Вставка элемента по индексу
        stringList.Insert(1, "Новый Второй");
        stringList.InsertRange(stringList.Count, new List<string>() { "Test4", "Test5" });

        // Вывод всех элементов
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(stringList);

        // Получение элемента по индексу
        string elementAtIndex = stringList[2];
        Console.WriteLine($"Элемент по индексу 2: {elementAtIndex}");

        // Проверка присутствия элемента
        bool containsElement = stringList.Contains("Третий");
        Console.WriteLine($"Список содержит 'Третий': {containsElement}");

        // Сортировка элементов
        stringList.Sort();
        Console.WriteLine("Отсортированная коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Бинарный поиск элемента
        // Перед использованием нужно отсортировать коллекцию
        var item = stringList.BinarySearch("Новый Второй");
        Console.WriteLine($"Бинарный поиск 'Новый Второй': {item}");

        // Поиск индекса элемента
        var index = stringList.IndexOf("Новый Второй");
        Console.WriteLine($"Поиск индекса 'Новый Второй': {index}");

        // Reverse элементов
        stringList.Reverse();
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Reverse группы элементов
        stringList.Reverse(1, stringList.Count - 1);
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Получение диапазона и копирование в массив
        List<string> range = stringList.GetRange(0, 2);
        Console.WriteLine("Часть коллекции:");
        PrintHelper.PrintCollection(range);

        string[] part = new string[3];
        stringList.CopyTo(0, part, 1, 2);
        Console.WriteLine("Копия коллекции:");
        PrintHelper.PrintCollection(part);
        
        // Пример ForEach
        stringList.ForEach(p => Console.WriteLine(p));
        
        /*
        // Удаление элемента по индексу
        stringList.RemoveAt(0);

        // Удаление элемента по значению
        bool result = stringList.Remove("Третий");
        Console.WriteLine($"Удаление элемента 'Третий': {result}");

        // Удаление группы элементов
        PrintHelper.PrintCollection(stringList);
        stringList.RemoveRange(0, 1);

        // Вывод после удаления
        Console.WriteLine("Элементы после удаления:");
        PrintHelper.PrintCollection(stringList);
        */

        // Очистка
        stringList.Clear();
        Console.WriteLine($"Capacity: {stringList.Capacity}");
    }
}