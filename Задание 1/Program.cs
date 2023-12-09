// See https://aka.ms/new-console-template for more information

using Задание_1;

Shape[] shapes = new Shape[10];
shapes[0] = new Square { Width = 2 };
shapes[1] = new Square { Width = 3 };
shapes[2] = new Square { Width = 4 };
shapes[3] = new Rectangle { Width = 5, Height = 2 };
shapes[4] = new Rectangle { Width = 3, Height = 4 };
shapes[5] = new Rectangle { Width = 1, Height = 6 };
shapes[6] = TriangleFactory.CreateTriangle(3, 4, 5);
shapes[7] = TriangleFactory.CreateTriangle(2, 2, 2);
shapes[8] = TriangleFactory.CreateTriangle(5, 1, 5);
shapes[9] = TriangleFactory.CreateTriangle(4, 5, 7);

foreach (var shape in shapes)
{
    shape.Area();
    Console.WriteLine();
}
Console.ReadKey();
