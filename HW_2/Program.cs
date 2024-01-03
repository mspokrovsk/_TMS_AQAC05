using HW_2;
using System;
using System.Collections.Generic;
// Создание словаря для хранения товаров
Dictionary<int, Product> products = new Dictionary<int, Product>();
bool run = true;
while (run)
{
    Console.WriteLine("Выберите функцию:");
    Console.WriteLine("1. Добавление товара");
    Console.WriteLine("2. Отображение списка товаров");
    Console.WriteLine("3. Поиск товара по идентификатору");
    Console.WriteLine("4. Обновление информации о товаре");
    Console.WriteLine("5. Удаление товара");
    Console.WriteLine("6. Выход из программы");
    int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        // Добавление товара в словарь
        Console.WriteLine("Введите название товара:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите цену товара:");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество товара:");
        int quantity = int.Parse(Console.ReadLine());
        int id = products.Count + 1;
        Product product = new Product(id, name, price, quantity);
        products.Add(id, product);
        Console.WriteLine("Товар успешно добавлен в список!");
        break;
    case 2:
        // Отображение списка товаров
        if (products.Count == 0)
        {
            Console.WriteLine("Список товаров пуст. Пожалуйста, добавьте товары.");
        }
        else
        {
            Console.WriteLine("Товары в списке:");
            foreach (KeyValuePair<int, Product> kvp in products)
            {
              Console.WriteLine("Id: {0}, Название: {1}, Цена: {2}, Количество: {3}", kvp.Value.Id, kvp.Value.Name, kvp.Value.Price, kvp.Value.Quantity);
            }
        }
        break;
    case 3:
        // Поиск товара по идентификатору
        Console.WriteLine("Введите идентификатор товара для поиска:");
        int searchId = int.Parse(Console.ReadLine());

        if (products.ContainsKey(searchId))
        {
            Product product1 = products[searchId];
            Console.WriteLine("Информация о товаре - Название: {0}, Цена: {1}, Количество: {2}", product1.Name, product1.Price, product1.Quantity);
        }
        else
        {
            Console.WriteLine("Товар не найден");
        }
        break;
    case 4:
        // Обновление информации о товаре
        while (true)
        {
            Console.WriteLine("Введите идентификатор товара для изменения (или 0 для выхода):");
            int idn = int.Parse(Console.ReadLine());

            if (idn == 0)
            {
                break;
            }

            if (products.ContainsKey(idn))
            {
                Console.WriteLine("Введите новую цену товара:");
                decimal newprice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Введите новое количество товара:");
                int newquantity = int.Parse(Console.ReadLine());

                Product newproduct = products[idn];
                newproduct.Price = newprice;
                newproduct.Quantity = newquantity;
                products[idn] = newproduct;

                Console.WriteLine("Информация о товаре успешно обновлена!");
            }
            else
            {
                Console.WriteLine("Товар не найден");
            }
        }
        break;
    case 5:
        // Удаление товара
        Console.WriteLine("Введите идентификатор товара для удаления:");
        int idr = int.Parse(Console.ReadLine());

        if (products.ContainsKey(idr))
        {
            products.Remove(idr);
            Console.WriteLine("Товар успешно удален из списка!");
        }
        else
        {
            Console.WriteLine("Ошибка: товар не найден");
        }
        break;
    case 6:
        run = false; // устанавливаем флаг для выхода из цикла
        break;
    default:
        Console.WriteLine("Неправильный выбор. Выберите функцию из списка:");
        break;
    }
}
