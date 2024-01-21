using LINQ.models;

namespace LINQ;

public class Select
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Получение такого же типа данных
        IEnumerable<int> queryResult =
            from number in _testIntSet
            select number;

        // Формирование нового типа данных
        IEnumerable<string> queryResult11 =
            from number in _testIntSet
            select number.ToString();

        IEnumerable<bool> queryResult12 =
            from number in _testIntSet
            select number % 2 == 0;

        PrintHelper.Print(queryResult, i => Console.WriteLine($"Int: {i}"));
        PrintHelper.Print(queryResult11, i => Console.WriteLine($"String: {i}"));
        PrintHelper.Print(queryResult12, i => Console.WriteLine($"Bool: {i}"));

        IEnumerable<Person> queryResult13 =
            from item in _testObjectSet
            select item;

        // Создание нового типа данных
        var queryResult14 =
            from person in _testObjectSet
            select new
            {
                person.Name,
                YearOfBirth = DateTime.Now.Year - person.Age
            };
        PrintHelper.Print(queryResult14, i => Console.WriteLine($"Object: {i}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Получение такого же типа данных
        IEnumerable<int> methodResult = _testIntSet.Select(number => number);
        
        // Получение трансформированного типа данных
        IEnumerable<string> methodResult1 = _testIntSet.Select(number => number.ToString());
        IEnumerable<bool> methodResult2 = _testIntSet.Select(number => number % 2 == 0);
        
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));
        PrintHelper.Print(methodResult1, i => Console.WriteLine($"String: {i}"));
        PrintHelper.Print(methodResult2, i => Console.WriteLine($"Bool: {i}"));

        // Получение такого же типа данных
        var methodResult3 = _testObjectSet.Select(obj => obj.Name);
        
        // Создание нового типа данных
        var methodResult4 = _testObjectSet.Select(person =>
            new
            {
                person.Name,
                YearOfBirth = DateTime.Now.Year - person.Age
            });
        PrintHelper.Print(methodResult4, i => Console.WriteLine($"Object: {i}"));
    }
}