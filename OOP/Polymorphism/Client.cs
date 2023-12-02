namespace Polymorphism;

public class Client
{
    public int Id;
    public string PhoneNumber;
    public string Email;
    
    public void Activate() {}
    public void Pause() {}
    public void Deactivate() {}

    public Client(int id)
    {
        Id = id;
    }

    public Client()
    {
    }

    public void CountBill(int hours, int rate)
    {
        int result = hours * rate;
        Console.WriteLine("void CountBill: " + result);
    }
    
    public void CountBill(int hours, int rate, int debt)
    {
        int result = hours * rate + debt;
        Console.WriteLine("void CountBill: " + result);
    }
    
    public int CountBill(int hours, int rate, int debt, int discount)
    {
        int result = hours * rate + debt - discount;
        Console.WriteLine("void CountBill: " + result);

        return result;
    }


    public virtual void SendNotification()
    {
        Console.WriteLine("Base notification....");
    }
}