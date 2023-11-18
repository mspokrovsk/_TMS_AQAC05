// See https://aka.ms/new-console-template for more information
//Задание 1
  /*  double number1;
    double number2;
    string operation;
    double result;
    Console.Write("Введите первое число: ");
    number1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите одну из допустимых операций(+, -, *, /): ");
    operation = Console.ReadLine();
    Console.Write("Введите второе число: ");
    number2 = Convert.ToDouble(Console.ReadLine());

    switch (operation)
    {
        case "+":
            {
                result = number1 + number2;
                Console.WriteLine("Результат равен: " + result);
                break;
            }
        case "-":
            {
                result = number1 - number2;
                Console.WriteLine("Результат равен: " + result);
                break;
            }
        case "*":
            {
                result = number1 * number2;
                Console.WriteLine("Результат равен: " + result);
                break;
            }
        case "/":
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: на 0 делить нельзя");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine("Результат равен: " + result);
                }
                break;
            }
        default:
            {
                Console.WriteLine("Ошибка: Вы ввели недопустимую операцию");
                break;
            }

    }*/
//Задание 2
Console.WriteLine("Введите число от -50 до 50:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= -40 && number <= -10)
{
    Console.WriteLine("Число входит в промежуток [-40, -10]");
}
else if (number >= -9 && number <= 0)
{
    Console.WriteLine("Число входит в промежуток [-9, 0]");
}
else if (number >= 1 && number <= 10)
{
    Console.WriteLine("Число входит в промежуток [1, 10]");
}
else if (number >= 11 && number <= 40)
{
    Console.WriteLine("Число входит в промежуток [11, 40]");
}
else
{
    Console.WriteLine("Число не входит ни в один из промежутков");
}
