namespace Generics;

public class StaticPerson<T>
{
    public static T? code;
    
    public T Id { get; }
    public string Name { get; }

    public StaticPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }

}