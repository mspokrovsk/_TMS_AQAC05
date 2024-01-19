namespace Delegate;

public class Example2
{
    private delegate string WithParameters(string name1, string name2);

    public void Run()
    {
        WithParameters withParameters1 = new (ShowMessage);
        WithParameters withParameters2 = ShowMessage;

        string result1 = withParameters1("Boris", "Ivan");
        string result2 = withParameters2("Olga", "Natasha");
        
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    private string ShowMessage(string value1, string value2)
    {
        Console.WriteLine($"{value1} {value2} Have fun!!!");

        return "successful";
    }
}