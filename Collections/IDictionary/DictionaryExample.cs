using Collections.Helper;

namespace Collections.IDictionary;

public class DictionaryExample
{
    public void Run()
    {
        // Создаем словарь с ключами и значениями типа string
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        
        // Добавляем элементы в словарь
        myDictionary.Add("apple", 10);
        myDictionary.Add("banana", 5);
        myDictionary.Add("cherry", 7);
        string key = "lemon";
        int value = 7;
        myDictionary.Add(key, value);

        if (!myDictionary.TryAdd("apple", 2))
        {
            Console.WriteLine("Данный ключ уже используется");
        }
        
        // Проверяем наличие ключа в словаре
        bool containsKey = myDictionary.ContainsKey("banana");
        Console.WriteLine($"ContainsKey(\"banana\"): {containsKey}");

        // Проверяем наличие значения в словаре
        Console.WriteLine($"ContainsValue(\"10\"): {myDictionary.ContainsValue(10)}");

        // Получаем значение по ключу
        int value1 = myDictionary["apple"];
        Console.WriteLine($"Value for key 'apple': {value1}");
        
        string key1 = "lemon1"; 
        //Console.WriteLine($"Value for key '': {myDictionary[key1]}"); // Ошибка
        
        int value2;
        if (myDictionary.TryGetValue(key1, out value2))
        {
            Console.WriteLine($"Value for key '{key1}': {value2}");
        }
        else
        {
            Console.WriteLine("Данный ключ отсутствует");
        }

        foreach (var key2 in myDictionary.Keys)
        {
            Console.WriteLine($"'{key2}' : {myDictionary[key2]}");
        }
        
        // Итерация по парам ключ-значение
        PrintHelper.PrintCollection(myDictionary);

        // Удаление элемента по ключу
        myDictionary.Remove("cherry");
        
        // Выводим элементы после удаления
        Console.WriteLine("Elements after removal:");
        PrintHelper.PrintCollection(myDictionary);

        // Очистка словаря
        myDictionary.Clear();

        // Выводим элементы после очистки
        Console.WriteLine("Elements after clearing:");
        PrintHelper.PrintCollection(myDictionary);
    }
}