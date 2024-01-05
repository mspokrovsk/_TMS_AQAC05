namespace Generics;

public class Company<P>
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = ceo;
    }
}