// See https://aka.ms/new-console-template for more information

// -====================== Ошибка ======================-
/*
int[] array = new int[3];
int value = array[5];
*/

// -====================== Исключение ======================-

using Exceptions;

/*
Object obj = null;
obj.GetHashCode();
*/

// -====================== Checked Exceptions ======================-
CheckedExceptions checkedExceptions = new CheckedExceptions();
// checkedExceptions.ReadFile("file.txt");

// -====================== Unchecked Exceptions ======================-
UncheckedExceptions uncheckedExceptions = new UncheckedExceptions();
// uncheckedExceptions.DivideNumbers(1, 0);

// -====================== Использования try -> catch -> finally ======================-
ExceptionUsage exceptionUsage = new ExceptionUsage();
//exceptionUsage.Template();
//exceptionUsage.ShortForm1();
//exceptionUsage.ShortForm2();
//exceptionUsage.ShortForm3();

//exceptionUsage.ManyCatch();

/*
try
{
    exceptionUsage.RunException(1, 0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

exceptionUsage.FilterCatch(1, 0);
exceptionUsage.FilterCatch(0, 1);
exceptionUsage.FilterCatch1(0, 1);
exceptionUsage.FilterCatch1(1, 0);
*/

// -====================== Обработка исключений и условные конструкции ======================-
/*
string? data = Console.ReadLine();

if (int.TryParse(data, out var x1))
{
    Console.WriteLine($"x = {x1}");
}
else
{
    Console.WriteLine("Некорректный ввод...");
}

try
{
    int x = Convert.ToInt32(data);
}
catch (FormatException e)
{
    Console.WriteLine(e);
}
*/

// -====================== Пробрасывание исключения ======================-
ThrowExceptions throwExceptions = new ThrowExceptions();
//throwExceptions.CheckUsername();
// throwExceptions.CheckUsername1();

// -====================== Собственные исключения ======================-
CustomExceptionUsage customExceptionUsage = new CustomExceptionUsage();
//customExceptionUsage.Run();
//customExceptionUsage.ProcessInput("  ");
customExceptionUsage.UseCustomArgumentException();
customExceptionUsage.UseCustomArgumentException1();
