namespace Delegate;

public class ActionExamples
{
    // Делегат Action представляет некоторое действие, которое ничего не возвращает
    
    public void SimpleAction()
    {
        Action simpleAction = () => Console.WriteLine("Hello World!!!");
        simpleAction();
        
        // Action<in T1, in T2,....in T16>
        Action<string> greetAction = name => Console.WriteLine($"Hello {name}");
        greetAction("John");

        Action<string, int> greetAction1 = (name, x) => Console.WriteLine($"Hello {name} {x}");
        greetAction1("John", 10);
    }

    public void PerformOperation(int x, int y, Action<int, int> operation)
    {
        operation(x, y);
    }

    public async Task Run()
    {
        asyncAction();

        Console.WriteLine("Main method continues executing other tasks...");
        Console.ReadLine();
    }

    private Action asyncAction = async () =>
    {
        Console.WriteLine("Async Action Start");
        await Task.Delay(2000);
        Console.WriteLine("Async Action End");
    };
}