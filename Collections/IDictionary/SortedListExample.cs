using Collections.Helper;

namespace Collections.IDictionary;

public class SortedListExample
{
    public void Run()
    {
        // Создаем отсортированный список для строк (ключи) и int (значения)
        SortedList<string, int> mySortedList = new SortedList<string, int>();
        
        // Добавляем элементы в отсортированный список
        mySortedList.Add("Apple", 10);
        mySortedList.Add("Cherry", 7);
        mySortedList.Add("Banana", 5);

        // Выводим элементы отсортированного списка
        Console.WriteLine("SortedList elements:");
        PrintHelper.PrintCollection(mySortedList);
        
        // Проверяем наличие ключа в отсортированном списке
        bool containsKey = mySortedList.ContainsKey("Banana");
        Console.WriteLine($"ContainsKey(\"Banana\"): {containsKey}");

        // Проверяем наличие значения в отсортированном списке
        bool containsValue = mySortedList.ContainsValue(7);
        Console.WriteLine($"ContainsKey(\"7\"): {containsValue}");

        // Получаем значение по ключу
        int value;
        if (mySortedList.TryGetValue("Apple", out value))
        {
            Console.WriteLine($"Value for key 'Apple': {value}");
        }

        Console.WriteLine($"Value for key 'Apple': {mySortedList["Apple"]}");
        
        // Поиск индекса ключа
        int index = mySortedList.IndexOfKey("Cherry");
        int value1 = mySortedList.GetValueAtIndex(index);
        Console.WriteLine($"Value for key 'Cherry': {value1}");
        
        mySortedList.SetValueAtIndex(index, 12);
        Console.WriteLine($"Value for key 'Cherry': {mySortedList.GetValueAtIndex(index)}");
        
        // Удаляем элемент по ключу
        mySortedList.Remove("Apple");
        mySortedList.RemoveAt(mySortedList.IndexOfKey("Cherry"));

        // Выводим элементы отсортированного списка
        Console.WriteLine("SortedList elements:");
        PrintHelper.PrintCollection(mySortedList);

        mySortedList.Clear();
    }
}