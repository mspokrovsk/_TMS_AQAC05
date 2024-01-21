namespace LINQ;

public class DataAggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Формирование более общего набора данных из двух простых
        var queryResult =
            from hotel in _testObjectSet.List
            from person in hotel.Persons
            select person;

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Создание временных переменных
        var queryResult = _testObjectSet.List.SelectMany(hotel => hotel.Persons);
        
        PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));
    }
}