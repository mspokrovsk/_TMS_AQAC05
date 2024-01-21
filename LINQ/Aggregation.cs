namespace LINQ;

public class Aggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Aggregate - в Query не используется
        // Sum - в Query не используется
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Aggregate
        var queryResult = _testIntSet.Aggregate((x, y) => x - y);
        var queryResult1 = _testIntSet.Aggregate(10, (acc, i) => acc + i);

        Console.WriteLine($"queryResult: {queryResult}");
        Console.WriteLine($"queryResult1: {queryResult1}");

        // Sum
        var queryResult3 = _testIntSet.Sum();
        var queryResult31 = _testObjectSet.Sum(person => person.Age);

        Console.WriteLine($"queryResult: {queryResult3}");
        Console.WriteLine($"queryResult: {queryResult31}");
        
        // Sum
        queryResult3 = _testIntSet.Max();
        queryResult3 = _testIntSet.Min();
        var queryResult32 = _testIntSet.Average();
    }
}
