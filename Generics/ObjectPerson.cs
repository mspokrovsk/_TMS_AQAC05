namespace Generics;

public class ObjectPerson
{
    public object Id { get; }
    public string Name { get; }

    public ObjectPerson(object id, string name)
    {
        Id = id;
        Name = name;
    }
}