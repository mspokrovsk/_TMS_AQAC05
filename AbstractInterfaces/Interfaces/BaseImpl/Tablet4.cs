namespace Interfaces.BaseImpl;

public class Tablet4 : Device1
{
    public override void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet4 Display: {information}");
    }
}