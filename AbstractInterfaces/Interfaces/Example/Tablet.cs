namespace Interfaces;

// Класс планшета, также реализующий интерфейс
public class Tablet : IDisplayable
{
    public void DisplayInformation(string information)
    {
        // Реализация отображения на экране планшета
        Console.WriteLine($"Tablet Display: {information}");
    }

    public void DrawBorders()
    {
        Console.WriteLine("Tablet: Рисуем границы");
    }
}