namespace Generics;

public class VaryGenericPerson<T> : GenericPerson<int>
{
    public T code;
        
    public VaryGenericPerson(int id, string name) : base(id, name)
    {
    }
}