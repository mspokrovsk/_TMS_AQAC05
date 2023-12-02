namespace Abstraction;

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
        Console.WriteLine("Клнструктор Client");
    }
/*
    public Client(int id, string phoneNumber, string email)
    {
        Id = id;
        PhoneNumber = phoneNumber;
        Email = email;
    }
*/
}