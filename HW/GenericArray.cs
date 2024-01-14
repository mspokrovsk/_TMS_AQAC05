using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace HW
{
    // Объявление обобщенного класса
    public class GenericArray<T>
    {
        private T[] array; // Объявление массива обобщенного типа

        // Метод для добавления данных в массив через консоль
        public void AddItemFromConsole()
        {
            T newItem;
            if (array == null)
            {
                array = new T[1]; // Создание нового массива с одним элементом
                Console.WriteLine("Введите элемент массива:");
                array[0] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Ввод данных с клавиатуры и добавление в массив
            }
            else
            {
                T[] newArray = new T[array.Length + 1]; // Создание нового массива большего размера
                Array.Copy(array, 0, newArray, 0, array.Length); // Копирование существующих элементов в новый массив

                Console.WriteLine("Введите элемент массива:");
                newItem = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Ввод данных с клавиатуры

                newArray[array.Length] = newItem; // Добавление нового элемента в конец массива
                array = newArray; // Присвоение ссылки на новый массив
            }
        }

        // Метод для удаления данных из массива через консоль
        public void RemoveItemByIndexFromConsole()
        {
            if (array != null && array.Length > 0)
            {
                Console.WriteLine("Текущий массив:");
                PrintArray(); // Вывод текущего массива в консоль

                Console.WriteLine("Введите индекс элемента для удаления:");
                int index;
                while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= array.Length)
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
                }

                T[] newArray = new T[array.Length - 1]; // Создание нового массива меньшего размера
                Array.Copy(array, 0, newArray, 0, index); // Копирование элементов до удаляемого элемента
                Array.Copy(array, index + 1, newArray, index, array.Length - index - 1); // Копирование элементов после удаляемого элемента
                array = newArray; // Присвоение ссылки на новый массив

                Console.WriteLine("Элемент успешно удален.");
            }
            else
            {
                Console.WriteLine("Массив пустой");
            }
        }

        // Метод для получения элемента из массива по индексу через консоль
        public T GetItemFromConsole()
        {
            if (array != null && array.Length > 0)
            {
                Console.WriteLine("Введите индекс элемента:");
                int index = Convert.ToInt32(Console.ReadLine()); // Ввод индекса с консоли
                if (index >= 0 && index < array.Length)
                {
                    return array[index]; // Возвращение элемента по указанному индексу
                }
                else
                {
                    Console.WriteLine("Индекс находится за пределами массива");
                    return default(T); // Возвращение значения по умолчанию для типа T
                }
            }
            else
            {
                Console.WriteLine("Массив пустой");
                return default(T); // Возвращение значения по умолчанию для типа T
            }
        }

        // Метод, возвращающий длину массива
        public int GetLength()
        {
            return array != null ? array.Length : 0; // Возвращение длины массива, либо 0, если массив пустой
        }

        // Метод для вывода содержимого массива в консоль
        public void PrintArray()
        {
            if (array != null)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Массив пустой");
            }
        }
    }
}
