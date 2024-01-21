namespace LINQ.models;

public record Person(string Name, int Age)
{
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    // Добавить только при работе со сложными объектами
    public virtual bool Equals(Person? person)
    {
        return (Name == person.Name) && (Age == person.Age);
    }
    
    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => HashCode.Combine(Name, Age);
}