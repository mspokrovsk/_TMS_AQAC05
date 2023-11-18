// See https://aka.ms/new-console-template for more information
//Задание 1
double number1;
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
            result = number1+number2;
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

}