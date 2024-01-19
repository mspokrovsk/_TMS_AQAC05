namespace Delegate;

public class Example5
{
    // Тип делегата
    private delegate void NoParameters();

    delegate int Operation(int x, int y);

    public void Run()
    {
        NoParameters noPrm = delegate { Console.WriteLine("Have fun!!!"); };
        
        // Делегаты как параметры методов
        Console.WriteLine(Test(noPrm));
        
        // Возвращение делегатов из метода
        Operation operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 4));
        
        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 4));
        
        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 4));

        OperationType[] operationTypes = (OperationType[])Enum.GetValues(typeof(OperationType));

        Operation operation1;
        foreach (OperationType type in operationTypes)
        {
            operation1 = SelectOperation(type);
            Console.WriteLine(operation1(11, 5));
        }
    }

    private bool Test(NoParameters delegateValue)
    {
        delegateValue();

        return true;
    }

    private int Add(int x, int y) => x + y;
    private int Subtrack(int x, int y) => x - y;
    private int Multiply(int x, int y) => x * y;
    
    private Operation SelectOperation(OperationType operationType)
    {
        switch (operationType)
        {
            case OperationType.Add: 
                return new Operation(ShowData) + Add;
            case OperationType.Subtract: return Subtrack;
            default: return Multiply;
        }
    }

    private int ShowData(int x, int y)
    {
        Console.WriteLine($"Начало операции с {x} {y}");

        return 0;
    }
}