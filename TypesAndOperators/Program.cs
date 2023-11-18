// See https://aka.ms/new-console-template for more information
//Задание 1
/*double number1;
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
              break;
          }
      case "-":
          {
              result = number1 - number2;
              break;
          }
      case "*":
          {
              result = number1 * number2;
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
              }
              return;
          }
      default:
          {
              Console.WriteLine("Ошибка: Вы ввели недопустимую операцию");
              return;
          }
Console.WriteLine("Результат равен: " + result);

  }*/

//Задание 2
/*int number;
  
Console.WriteLine("Введите число от -50 до 50:");
number = Convert.ToInt32(Console.ReadLine());

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
}*/

//Задание 3
/*string[] word = {"отличная", "ужасная", "приятная", "переменчивая", "неустойчивая", "чудесная", "суровая", "непредсказуемая", "отвратительная", "мерзкая" };
string word3;
string translation = "";

Console.WriteLine("Я русско-английский переводчик и я знаю всего 10 слов о погоде:");
foreach (string word2 in word) //пробую практиковать параллельно с лекцией
{
    Console.WriteLine($"{word2} ");
}
Console.Write("Введите слово на русском языке: ");
word3 = Console.ReadLine();

switch (word3)
{
    case "отличная":
        translation = "excellent";
        break;
    case "ужасная":
        translation = "terrible";
        break;
    case "приятная":
        translation = "nice";
        break;
    case "переменчивая":
        translation = "changeable";
        break;
    case "неустойчивая":
        translation = "unsettled";
        break;
    case "чудесная":
        translation = "superb";
        break;
    case "суровая":
        translation = "inclement";
        break;
    case "непредсказуемая":
        translation = "unpredictable";
        break;
    case "отвратительная":
        translation = "miserable";
        break;
    case "мерзкая":
        translation = "foul";
        break;
    default:
        Console.WriteLine("Ошибка: я не знаю это слово");
        return;
}

Console.WriteLine("Перевод: " + translation);*/

//Задание 4.1
int number;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    {
    Console.WriteLine("Число четное");
    }
else
{
    Console.WriteLine("Число нечетное");
}

//Задание 4.2
int number2;

Console.Write("Введите число: ");
number2 = Convert.ToInt32(Console.ReadLine());

string parity = (number2 % 2 == 0) ? "четное" : "нечетное";
Console.WriteLine("Число " + parity);