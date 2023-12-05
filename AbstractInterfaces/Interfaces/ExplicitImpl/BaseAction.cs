namespace Interfaces.ExplicitImpl;

public class BaseAction : IAction
{
    void IAction.Move() => Console.WriteLine("Move in BaseAction class...");
}