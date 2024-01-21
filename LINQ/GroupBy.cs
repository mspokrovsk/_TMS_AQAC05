using LINQ.models;

namespace LINQ;

public class GroupBy
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Group By
        var queryResult2 =
            from person in _testObjectSet
            group person by person.Name
            into result
            orderby result.Key
            select new { GroupName = result.Key, Count = result.Count()};

        PrintHelper.Print(queryResult2, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult2 = _testObjectSet
            .GroupBy(person => person.Age)
            .Select(result => new { GroupName = result.Key, Count = result.Count() });
        PrintHelper.Print(queryResult2, item => Console.WriteLine($"Person: {item}"));
    }
}