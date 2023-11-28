namespace Classes.Models;

public class PersonThis
{
    // Блок полей (переменных)
    public string name;
    public int age;

    // Блок конструктора
    public PersonThis()
    {
        name = "Неизвестно";
        age = 18;
    }

    public PersonThis(string name)
    {
        this.name = name;
        age = 18;
    }

    public PersonThis(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Блок методов и свойств
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}