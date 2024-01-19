namespace Delegate;

public class Example8
{
    delegate T Operation<T, K>(K variable);
        
    public void Run()
    {
        Operation<decimal, int> squareOperation = Square;
        decimal result1 = squareOperation(5);
        Console.WriteLine(result1);

        Operation<int, int> doubleOperation = Double;
        int result2 = doubleOperation(5);
        Console.WriteLine(result2);
    }

    private decimal Square(int n) => n * n;
    private int Double(int n) => n + n;
}