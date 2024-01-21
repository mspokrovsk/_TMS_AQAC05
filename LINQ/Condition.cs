namespace LINQ;

public class Condition
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // All
        bool allResult = _testStringSet.List.All(text => text.Length < 7);
        Console.WriteLine($"Bool All: {allResult}");

        // Any
        allResult = _testStringSet.List.Any(text => text.Length == 2);
        Console.WriteLine($"Bool Any: {allResult}");

        // Contains
        allResult = _testStringSet.List.Contains("Tom");
        Console.WriteLine($"Bool Contains: {allResult}");
    }
}