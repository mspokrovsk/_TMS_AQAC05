namespace LINQ;

public class TwoInOne
{
    private TestIntSet _testIntSet = new TestIntSet();

    public void Run()
    {
        // Query Syntax + Method Syntax
        Console.WriteLine("Two in One");

        // Count
        int countResult =
        (
            from number in _testIntSet
            where number % 2 != 0
            select number
        ).Count();
        Console.WriteLine($"{countResult}");
        
        int maxResult =
            (from number in _testIntSet
                where number % 2 == 0
                select number).Max();
        Console.WriteLine($"{maxResult}");
    }
}