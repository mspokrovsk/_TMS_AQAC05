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

    public void CountBill(double hours, double rate)
    {
        double result = hours * rate;
        Console.WriteLine("void CountBill: " + result);
    }
    
    /*
    int Sum(int x, int y)
    {
        return x + y;
    }
    int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    void Sum(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    
    Сигнатура у всех этих методов будет совпадать:
    Sum(int, int)
    */


    public virtual void SendNotification()
    {
        Console.WriteLine("Base notification....");
    }
    
    //Очень кратко о свойствах - только база
    private string address;

    public virtual string Address
    {
        get
        {
            return address;
        }
        set
        {
            address = value;
        }
    }
}