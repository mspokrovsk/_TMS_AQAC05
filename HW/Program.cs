using HW;

//Задача 1
// Создание объекта Point с целочисленными координатами
Point<int> point = new Point<int>(3, 4);
point.Display();

//Задача 2
// Создание экземпляра обобщенного класса для хранения целочисленных значений
GenericArray<int> intArray = new GenericArray<int>();

// Добавление данных в массив через консоль
intArray.AddItemFromConsole();
intArray.AddItemFromConsole();
intArray.AddItemFromConsole();

// Вывод массива в консоль
intArray.PrintArray();
// Получение длины массива
int length = intArray.GetLength();
Console.WriteLine("Длина массива: " + length);

//Получение элемента из массива по индексу
int element = intArray.GetItemFromConsole();
Console.WriteLine("Элемент массива: " + element);

// Удаление данных из массива
intArray.RemoveItemByIndexFromConsole();

// Вывод массива в консоль
Console.WriteLine("Текущий массив:");
intArray.PrintArray();