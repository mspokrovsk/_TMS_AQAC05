namespace Interfaces.Example;

public interface IDisplayable
{
    void DisplayInformation(string information);

    // Проблема добавления нового метода - требует реализации во всех классах использующих этот interface
    //public void DrawBorders();
    // Решение проблемы добавления нового метода - теперь не требует реализации во всех классах использующих этот interface
    void DrawBorders()
    {
        Console.WriteLine("Рисуем границы");
    }
}