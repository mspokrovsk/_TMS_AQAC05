namespace Interfaces;

public class StaticExample
{
    public static int StaticVariable = 0;
    public int InstanceVar;

    public StaticExample()
    {
        StaticVariable++;
        InstanceVar = StaticVariable;
    }

    public static void Print()
    {
        Console.WriteLine($"Static Variable: {StaticVariable}");
    }
}