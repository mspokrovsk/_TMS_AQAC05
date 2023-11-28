namespace Classes.Models;

public class PersonChain
{
    public string name;
    public int age;

    public PersonChain() : this("Неизвестно") // первый конструктор
    {
    }

    public PersonChain(string name) : this(name, 18) // второй конструктор
    {
    }

    public PersonChain(string name, int age) // третий конструктор
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}