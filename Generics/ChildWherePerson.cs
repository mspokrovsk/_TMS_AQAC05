namespace Generics;

public class ChildWherePerson<T> : GenericPerson<T> where T : class
{
    public ChildWherePerson(T id, string name) : base(id, name)
    {
    }
}