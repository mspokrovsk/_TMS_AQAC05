using LINQ.models;

namespace LINQ;

public class Distinct
{
    List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from i in numbers
            group i by i
            into result
            select result.Key;

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = numbers.Distinct();

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }
}