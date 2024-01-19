using System.Net.Sockets;

namespace Delegate;

public class FuncExample
{
    // Делегат Func. Он возвращает результат действия и может принимать параметры
    // Func<in T1, in T2,...in T16, out TResult>()

    public void Run()
    {
        int result = DoOperation(6, x => x * 2);
        Console.WriteLine(result);
        
        result = DoOperation(6, Square);
        Console.WriteLine(result);

        Func<int, int, string> randomString = (a, b) => $"{a} + {b}";
        Console.WriteLine(randomString(1, 2));
    }

    int DoOperation(int n, Func<int, int> operation) => operation(n);
    int Square(int n) => n * n;
}