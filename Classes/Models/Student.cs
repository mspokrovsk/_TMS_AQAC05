namespace Classes.Models;

public class Student
{
    public string name;
    public int group;
    public int diplomMark;

    public Student()
    {
    }

    public Student(string name)
    {
        this.name = name;
        group = 1;
        diplomMark = new Random().Next(1, 11); 
    }
    
    public void Print()
    {
        Console.Write($"Name: {name}, Group: {group}, Mark: {diplomMark}");
        Console.WriteLine();
    }
}