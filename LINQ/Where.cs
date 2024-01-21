namespace LINQ;

public class Where
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from number in _testIntSet
            where number % 2 == 0 
            where number > 5
            select number;
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Int: {i}"));

        var queryResult1 =
            from s in _testStringSet.List
            where s.StartsWith("A")
            select s;
        PrintHelper.Print(queryResult1, s => Console.WriteLine($"String: {s}"));

        var queryResult2 =
            from obj in _testObjectSet
            where obj.Age >= 45
            select obj;
        PrintHelper.Print(queryResult2, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
            
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var methodResult = _testIntSet.Where(num => num % 2 == 0 && num > 5).Select(num => num);
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));
        
        var methodResult1 = _testStringSet.List.Where(s => s.StartsWith("A")).Select(s => s);
        PrintHelper.Print(methodResult1, s => Console.WriteLine($"String: {s}"));

        var methodResult2 = _testObjectSet.Where(item => item.Age >= 45).Select(item => item);
        PrintHelper.Print(methodResult2, item => Console.WriteLine($"Person: {item}"));
    }
}