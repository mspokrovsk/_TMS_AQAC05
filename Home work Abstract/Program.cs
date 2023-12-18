// See https://aka.ms/new-console-template for more information
//Задание 1
using Home_work_Abstract;
using System.Collections.Generic;

Shape[] shapes = new Shape[5];
shapes[0] = new Triangle(3, 4, 5);
shapes[1] = new Rectangle(4, 5);
shapes[2] = new Circle(3);
shapes[3] = new Triangle(5, 5, 5);
shapes[4] = new Rectangle(3, 6);

double totalArea = 0;
double totalPerimeter = 0;
foreach (var shape in shapes)
{
    totalArea += shape.CalculateArea();
    totalPerimeter += shape.CalculatePerimeter();
}
Console.WriteLine("Сумма площади всех фигур: " + totalArea);
Console.WriteLine("Сумма периметра всех фигур: " + totalPerimeter);
//Задание 2
List<Product> products = new List<Product>
        {
            new Good { Name = "Молоко", Price = 2.5m, ProductionDate = new DateTime(2023, 12, 1), ExpiryDate = new DateTime(2023, 12, 20) },
            new Batch { Name = "Хлеб", Price = 1.2m, Quantity = 10, ProductionDate = new DateTime(2023, 12, 5), ExpiryDate = new DateTime(2023, 12, 15) },
            new Set { Name = "Набор продуктов", Price = 15.0m, Products = new List<Product>
                {
                    new Good { Name = "Яблоко", Price = 1.0m, ProductionDate = new DateTime(2023, 12, 10), ExpiryDate = new DateTime(2023, 12, 25) },
                    new Good { Name = "Мороженое", Price = 5.0m, ProductionDate = new DateTime(2023, 12, 5), ExpiryDate = new DateTime(2023, 12, 20) }
                }
            }
        };
foreach (var product in products)
{
    product.PrintInfo();
}
var expiredProducts = products.Where(p => p.IsExpired());
foreach (var product in expiredProducts)
{
    Console.WriteLine($"Просроченный товар: {product.Name}");
}
Console.ReadKey();

