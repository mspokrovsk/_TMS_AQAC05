namespace Interfaces.BaseImpl;

public class Tablet5 : Device2
{
    public new void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet5 Display: {information}");
    }
}