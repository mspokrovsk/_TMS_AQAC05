namespace Generics;

public class IntGenericPerson : GenericPerson<int>
{
    public IntGenericPerson(int id, string name) : base(id, name)
    {
    }
}