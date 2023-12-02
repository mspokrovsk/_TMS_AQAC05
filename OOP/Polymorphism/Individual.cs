public class Individual : Client
{
    public string Firstname;
    public string Lastname;
    
    public Individual(int id) : base(id)
    {
        Console.WriteLine("Individual Base HashCode: " + base.GetHashCode());
    }

    public override void SendNotification()
    {
        base.SendNotification();
        Console.WriteLine("Уважаемый клиент...");
    }
}