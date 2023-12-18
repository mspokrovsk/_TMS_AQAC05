using Interfaces.Example;

namespace Interfaces.BaseImpl;

public class Device2 : IDisplayable
{
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Device2 Display: {information}");
    }
}