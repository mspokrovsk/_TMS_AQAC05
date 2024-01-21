using LINQ.models;

namespace LINQ;

public class BaseSyntax
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // from (имя переменной) in (источник данных)
        // select переменная;
        
        // Query Syntax
        Console.WriteLine("Query Syntax");

        IEnumerable<int> queryResult =
            from number in _testIntSet
            select number;

        foreach (int i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
        
        IEnumerable<string> queryResult1 =
            from s in _testStringSet.List
            select s;
        PrintHelper.Print(queryResult1, i => Console.WriteLine($"String: {i}"));

        IEnumerable<Person> queryResult2 =
            from person in _testObjectSet
            select person;
        PrintHelper.Print(queryResult2, obj => Console.WriteLine($"Person: {obj}"));

    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        IEnumerable<int> methodResult = _testIntSet.Select(number => number);
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));

        IEnumerable<string> methodResult1 = _testStringSet.List.Select(test => test + "!");
        PrintHelper.Print(methodResult1, s => Console.WriteLine($"String: {s}"));

        IEnumerable<Person> methodResult2 = _testObjectSet.Select(item => item);
        PrintHelper.Print(methodResult2, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunStringExtension()
    {
        // Метод расширения String
        string test = "test";
        Console.WriteLine($"Char: {test.GetChar(0)}");
    }
}