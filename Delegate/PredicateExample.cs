namespace Delegate;

public class PredicateExample
{
    // Делегат Predicate<T> принимает один параметр и возвращает значение типа bool
    
    public void Run()
    {
        Predicate<int> isPositive = x => x > 0;
        
        Console.WriteLine(isPositive(10));
        Console.WriteLine(isPositive(-10));
    }
}