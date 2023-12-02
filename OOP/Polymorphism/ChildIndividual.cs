namespace Polymorphism;

public class ChildIndividual : Individual
{
    public ChildIndividual(int id) : base(id)
    {
    }
    
    public override void SendNotification()
    {
        base.SendNotification();
        Console.WriteLine("Уважаемый клиент... Версия 2");
    }
}