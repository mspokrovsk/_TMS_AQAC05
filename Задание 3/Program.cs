using Задание_3;
class Program
{
    static void Main(string[] args)
{
    int[] randomArray = GenerateRandomArray(10); // создание массива из 10 случайных чисел с помощью метода GenerateRandomArray
    Console.WriteLine("Исходный массив:");
    PrintArray(randomArray); //вывод на экран созданного массива

    SortingType sortingType = (SortingType)new Random().Next(0, 2); //выбор случайным образом тип сортировки из SortingType
    SortingDelegate sortingDelegate = SortingHelper.GetSortingDelegate(sortingType); //инстанцируем экземпляр делегата с ссылкой на метод сортировки
    int[] sortedArray = sortingDelegate(randomArray); //вызов делегата

    Console.WriteLine($"Отсортированный массив с использованием {sortingType}:");
    PrintArray(sortedArray); //вывод сортированного массива в виде строки
}

static int[] GenerateRandomArray(int size) //метод создания массива случайных чисел
{
    var random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(int.MinValue, int.MaxValue);
    }
    return array;
}

static void PrintArray(int[] array) //метод печати массива на экран
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}
}
