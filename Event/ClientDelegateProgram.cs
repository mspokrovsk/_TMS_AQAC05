namespace Event;

public class ClientDelegateProgram
{
    public void Run()
    {
        var clients = new Client[2];

        Client client1 = new Client();
        client1.Type = ClientType.Corporate;

        Client client2 = new Client();
        client2.Type = ClientType.Individual;

        clients[0] = client1;
        clients[1] = client2;
        
        ClientDelegate clientDelegate = new ClientDelegate();
        CalculateHelper calculateHelper = new CalculateHelper();

        clientDelegate.CalculateDiscountForClient = calculateHelper.CalcDiscount; 
        
        clientDelegate.CalculateDiscounts(clients);

        foreach (var client in clients)
        {
            Console.WriteLine($"Discount is: {client.Discount}");
        }
    }
}