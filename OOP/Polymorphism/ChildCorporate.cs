namespace Polymorphism;

public class ChildCorporate : Corporate
{
    public ChildCorporate(int id) : base(id)
    {
    }
    
    /*
    public override void SendNotification() - Ошибка
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
    */

}