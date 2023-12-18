namespace Interfaces.Example;

public class Smartphone : IDisplayable
{
    public int UUID;
    
    public void DisplayInformation(string information)
    {
        // Реализация отображения на экране смартфона
        Console.WriteLine($"Smartphone Display: {information}");
    }
}