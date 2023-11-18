// See https://aka.ms/new-console-template for more information

{
    // Это сообщение будет выведено на экран
    /*
     Это сообщение будет выведено на экран
     */
    /*
    Console.WriteLine("Hello, World!");
    {
        Console.WriteLine("It's a nice day!");
    }

    const int MINUTES_IN_HOUR = 60;

    string name;

    name = "Bob";
    Console.WriteLine(name);

    name = "Bob1";
    Console.WriteLine(name);

    name = "Bob2";
    Console.WriteLine(name);

    Console.WriteLine(true);
    Console.WriteLine(false);

    Console.WriteLine(-10);
    Console.WriteLine(0);
    Console.WriteLine(10);
    Console.WriteLine(0b10011);

    Console.WriteLine(1.24);
    Console.WriteLine(1.24F);

    Console.WriteLine('H');

    //Console.WriteLine(null);

    Console.WriteLine("It's a \t nice day!");
    Console.WriteLine("It's a \n nice day!");
    Console.WriteLine("It's a '\' nice day!");

    bool flag = true;
    flag = false;

    sbyte sb = 100;

    float a = 3.14F;
    float a1 = 3.14f;

    decimal c = 1005.5M;
    decimal c1 = 1005.5m;

    var d = 10;
    var d1 = 10.2F;
    var d2 = 'D';
    var d3 = "Thank's";

    int j;
    j = 20;

    var j1 = 20;
*/

    /*
    Console.WriteLine("Добро пожаловать в C#");
    Console.Write("Надеюсь Вы ");
    Console.Write("постигните нюансы в C#! \n");
    Console.WriteLine("И все будет супер гуд!!!");
    */

    /*
    int j;
    j = 20;

    Console.WriteLine("J = " + j);

    string name = "Tom";
    int age = 34;
    double height = 1.7;

    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}");
    Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}", name, height, age);
    */

    /*
    Console.WriteLine("Введите свое имя:");
    string? name = Console.ReadLine();
    Console.WriteLine($"Ваше имя: {name}");

    Console.WriteLine("Введите свой возраст:");
    string? age_str = Console.ReadLine();
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Ваш возраст: {age}");
    */

    /*
    double x = 10.0;
    double z = x % 4;
    Console.WriteLine($"Результат: {z}");

    int a = 10;

    bool c = a != 10;
    Console.WriteLine($"Результат: {c}");
    */

    /*
    if (условние)
    {

    }
    */

    /*
    bool a = false;
    bool b = true;
    string name1 = "Tom";
    string name2 = "Tom";

    if ( !(name1.Equals(name2) && b) )
    {
        Console.WriteLine("Верно");
    }
    else
    {
        Console.WriteLine("Не верно");
    }
    */
    /*
        int x = 10;
        int y = 20;
        int z;

        if ( x < y )
        {
            z = x + y;
        }
        else
        {
            z = x - y;
        }

        z = x < y ? x + y : x - y;

    */
    /*
    // Решение нашей задачи
    // Подготовка данных
    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milkFatPercentage = 1.2F;
    ushort icecreaPrice = 350;

    Console.Write("Введите начальную сумму: ");
    string? sumString = Console.ReadLine();
    short sum = Convert.ToInt16(sumString);

    if (sum > 0)
    {
        if (!isWhiteBreadFresh)
        {
            Console.WriteLine("Батон не свежий");
        }
        else if (sum >= whiteBreadPrice)
        {
            sum = Convert.ToInt16(sum - whiteBreadPrice);
            Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
        }
        else
        {
            Console.WriteLine("На батон денег не хватает");
        }

        sum = (short)(sum - butterPrice);

        if (milkFatPercentage == 1.2F)
        {
            sum = Convert.ToInt16(sum - milkPrice);
        }

        if (sum >= icecreaPrice)
        {
            sum = Convert.ToInt16(sum - icecreaPrice);
        }

        Console.WriteLine($"Остаток суммы: {sum}");
    }
    else
    {
        Console.WriteLine("Сумма не может быть меньше 0");
    }
    */
}


int x = 6;

if (x == 1)
{
    Console.WriteLine("1");
}
else if (x == 2)
{
    Console.WriteLine("2");
}
else if (x == 3)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("Не соответствует условиям");
}

switch (x)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    default:
        Console.WriteLine("Не соответствует условиям");
        break;
}

string name = "Alex1";

switch (name)
{
    case "Alex":
        Console.WriteLine("Alex");
        break;
    case "Tom":
        Console.WriteLine("Tom");
        break;
}

string name1 = "Alex1";

switch (name1.Equals("Alex"))
{
    case true:
        Console.WriteLine("Alex");
        break;
    case false:
        Console.WriteLine("Tom");
        break;
}

Console.WriteLine(DoOperation(1));
Console.WriteLine(DoOperation(2));
Console.WriteLine(DoOperation(3));


int DoOperation(int x)
{
    switch (x)
    {
        case 1:
            return 1;
        case 2:
            return 2;
        default: return 0;
    }
}

int DoOperation1(int x)
{
    int result = x switch
    {
        1 => 1,
        2 => 2,
        _ => 0
    };

    return result;
}

int DoOperation2(int x) => x switch
{
    1 => 1,
    2 => 2,
    _ => 0
};

//Задания из презентации

/*double pi = 3.141592653;
double e = 2.718281828459045;
Console.WriteLine($"Rezult: pi = {pi}, e = {e}");

string a = "\nмоя строка 1"; // \n - перенос на след строку
string b = "\tмоя строка 2"; // \е - большой пробел
string c = "\aмоя строка 3"; // \c - без пробелов
Console.WriteLine($"Rezult: a = {a}, b = {b}, c = {c}");*/
