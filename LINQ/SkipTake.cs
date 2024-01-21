namespace LINQ;

public class SkipTake
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

        // Skip
        Console.WriteLine("Skip");
        var queryResult = _testStringSet.List.Skip(2);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
        
        Console.WriteLine("SkipLast");
        queryResult = _testStringSet.List.SkipLast(2);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
        
        Console.WriteLine("SkipWhile");
        queryResult = _testStringSet.List.SkipWhile(p => p.Length == 3);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));

        // Take
        Console.WriteLine("Take");
        queryResult = _testStringSet.List.Take(2);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));

        Console.WriteLine("TakeLast");
        queryResult = _testStringSet.List.TakeLast(2);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));

        Console.WriteLine("TakeWhile");
        queryResult = _testStringSet.List.TakeWhile(p => p.Length == 3);
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));

    }
}