using System.Collections;
using Collections.IDictionary;

namespace Collections.Helper;

public static class PrintHelper
{
    /*
    // Обычный вариант
    public static void PrintCollection(System.Collections.IList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    // Обычный вариант
    public static void PrintCollection(Dictionary<string, int> dictionary)
    {
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }

    // Обычный вариант
    public static void PrintCollection(SortedDictionary<string, int> dictionary)
    {
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
    */   
    
    // Общий метод для печати элементов IEnumerable
    public static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            if (item is DictionaryEntry)
            {
                // Обработка случая словаря
                var entry = (DictionaryEntry)item;
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            else
            {
                // Обработка других случаев
                Console.WriteLine(item);
            }
        }
    }
}