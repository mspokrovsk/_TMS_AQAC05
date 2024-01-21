namespace LINQ;

public class SingleItem
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // First
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // First
        var queryResult = _testIntSet.Where(num => num == 4 || num == 6).First();
        var queryResult1 = _testIntSet.First(num => num == 4 || num == 6);
        //var queryResult2 = _testIntSet.First(num => num == 12); // Exception

        Console.WriteLine($"queryResult1: {queryResult}");
        Console.WriteLine($"queryResult2: {queryResult1}");
        //Console.WriteLine($"queryResult: {queryResult2}");
        
        // FirstOrDefault
        var queryResult3 = _testIntSet.FirstOrDefault(num => num == 4 || num == 6);
        var queryResult4 = _testIntSet.FirstOrDefault(num => num == 12);

        var queryResult31 = _testIntSet.Last(num => num == 4);
        var queryResult32 = _testIntSet.LastOrDefault(num => num == 4 || num == 6);

        Console.WriteLine($"queryResult3: {queryResult3}");
        Console.WriteLine($"queryResult4: {queryResult4}");
        
        // Single
        var queryResult5 = _testIntSet.Single(num => num == 4);
        //var queryResult6 = _testIntSet.Single(num => num == 4 || num == 6); // Exception
        
        var queryResult6 = _testIntSet.SingleOrDefault(num => num == -4 || num == -6); // Нет Exception
        
        Console.WriteLine($"queryResult5: {queryResult5}");
        Console.WriteLine($"queryResult6: {queryResult6}");
    }
}
