namespace LINQ;

public class Join
{
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public record PersonPosition(string Firstname, string Position);

    public List<PersonPosition> additionalList = new List<PersonPosition>()
    {
        new PersonPosition("Michel", "QA"),
        new PersonPosition("Oleg", "AQA"),
        new PersonPosition("Alex", "Developer"),
        new PersonPosition("Olga", "HR"),
        new PersonPosition("Stanislav", "QA"),
        new PersonPosition("Tom", "AQA")
    };


    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from person in _testObjectSet
            join person1 in additionalList on person.Name equals person1.Firstname
            select new { person.Name, person.Age, person1.Position };
            //select new { Name = person.Name, Age = person.Age, Position = person1.Position };

        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = _testObjectSet
            .Join(additionalList,
                person => person.Name,
                person1 => person1.Firstname,
                (person, position) => new { person.Name, person.Age, position.Position });
        
        PrintHelper.Print(queryResult, s => Console.WriteLine(s));
    }
}