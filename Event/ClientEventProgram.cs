namespace Event;

public class ClientEventProgram
{
    public void Run()
    {
        var clients = new Client[2];
        
        Client client1 = new Client();
        client1.Type = ClientType.Corporate;
        client1.Email = "test1@test.com";

        Client client2 = new Client();
        client2.Type = ClientType.Individual;
        client2.Email = "test2@test.com";

        clients[0] = client1;
        clients[1] = client2;

        ClientEvent clientEvent = new ClientEvent();
        
        clientEvent.Notified += new NotificationHelper().NotifyByEmail;
        
        clientEvent.NotifyClients(clients);
    }
}