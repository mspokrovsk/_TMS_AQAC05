namespace Interfaces.ExplicitImpl;

public class HeroAction : BaseAction1, IAction
{
    void IAction.Move()
    {
        Console.WriteLine("Move in HeroAction class...");
    }
}