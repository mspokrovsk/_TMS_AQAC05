namespace Event;

public class ClientEvent
{
    public delegate void Notificate(string email);

    public event Notificate Notified;

    public void NotifyClients(IEnumerable<Client> clients)
    {
        foreach (Client client in clients)
        {
            // какой-то код бизнес логики - например подготовка сообщения
            string emailMsg = client.Email + "   Congratulation!!!";
            
            // Оповещение
            Notified(emailMsg);
        }
    }
}