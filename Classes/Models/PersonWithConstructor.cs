namespace Classes.Models;

public class PersonWithConstructor
{
    // Блок полей (переменных)
    public string name;   // имя
    public int age;                     // возраст
    public int surname;                 // фамилия

    public PersonWithConstructor()
    {
        name = "Undefined";
        age = 1;
    }
    
    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}