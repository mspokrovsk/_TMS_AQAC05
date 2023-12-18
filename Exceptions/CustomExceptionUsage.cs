namespace Exceptions;

public class CustomExceptionUsage
{
    public void Run()
    {
        try
        {
            // Генерируем собственное исключение
            throw new CustomException("Произошла ошибка!");

            // Код после генерации исключения не выполнится
            Console.WriteLine("Этот код не будет достигнут.");
        }
        catch (CustomException ex)
        {
            // Обрабатываем собственное исключение
            Console.WriteLine($"Поймано собственное исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Обработка других исключений, если они возникнут
            Console.WriteLine($"Поймано исключение: {ex.Message}");
        }
    } 
    
    public void ProcessInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new InvalidInputException(nameof(input), "Поле не должно быть пустым или содержать только пробелы.");
        }

        // Дополнительная логика обработки ввода
    }
    
    public void UseCustomArgumentException()
    {
        try
        {
            Employee person = new Employee { Name = "Tom", Age = 17 };
        }
        catch (CustomArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            // Становиться доступным новое свойство в ex
            Console.WriteLine($"Некорректное значение: {ex.Value}");
        }
    }

    public void UseCustomArgumentException1()
    {
        try
        {
            Employee person = new Employee { Name = "Tom", Age = 17 };
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            // Становиться доступным новое свойство в ex
            //Console.WriteLine($"Некорректное значение: {ex.Value}");
        }
    }
}