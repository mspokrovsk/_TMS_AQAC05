namespace Generics;

public class ChildGenericPerson<T> : GenericPerson<T>
{
    public ChildGenericPerson(T id, string name) : base(id, name)
    {
    }
}