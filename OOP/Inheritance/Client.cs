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
}