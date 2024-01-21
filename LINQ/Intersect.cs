using LINQ.models;

namespace LINQ;

public class Intersect
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    private List<int> blackList = new() { -1, -3, 3, 6, 8, 12};
    
    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from number in _testIntSet
            where blackList.Contains(number)
            select number;
        
        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = _testIntSet.Intersect(blackList);
        
        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }
}