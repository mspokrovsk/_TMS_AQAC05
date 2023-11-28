namespace Classes.Models;

// Set C# 12 для проекта
public class PersonPrimaryConstructors(string name, int age)
{
    public PersonPrimaryConstructors(string name) : this(name, 18)
    {
    }

    public void Print() => Console.WriteLine($"name: {name}, age: {age}");
}