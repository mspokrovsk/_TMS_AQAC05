using Collections.Helper;

namespace Collections.IDictionary;

public class SortedDictionaryExample
{
    public void Run()
    {
        // Создаем сортированный словарь для строк (ключи) и int (значения)
        SortedDictionary<string, int> mySortedDictionary = new SortedDictionary<string, int>();
        
        // Добавляем элементы в сортированный словарь
        mySortedDictionary.Add("Apple", 10);
        mySortedDictionary.Add("Cherry", 7);
        mySortedDictionary.Add("Banana", 5);

        // Выводим элементы сортированного словаря
        Console.WriteLine("SortedDictionary elements:");
        PrintHelper.PrintCollection(mySortedDictionary);

        // Проверяем наличие ключа в сортированном словаре
        bool containsKey = mySortedDictionary.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

        // Получаем значение по ключу
        int value;
        if (mySortedDictionary.TryGetValue("Apple", out value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        // Удаляем элемент по ключу
        mySortedDictionary.Remove("Cherry");

        // Выводим элементы после удаления
        Console.WriteLine("SortedDictionary elements after removal:");
        PrintHelper.PrintCollection(mySortedDictionary);
    }
}