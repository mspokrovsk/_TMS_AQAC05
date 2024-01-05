namespace Generics;

public class Person<T, K>
{
    public T Id { get; }
    public K Code { get; set; }
    public string Name { get; }

    public Person(T id, K code, string name)
    {
        Id = id;
        Code = code;
        Name = name;
    }
}