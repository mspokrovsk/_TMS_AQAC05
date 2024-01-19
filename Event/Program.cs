// See https://aka.ms/new-console-template for more information

using Event;

class Program
{
    public delegate void Handler(string alpha, string beta);

    //public static event Handler OnStuck;
    public static Handler OnStuck;
        
    static void Main()
    {
        //OnStuck += ShowMessage;
        //OnStuck("Alex", "Trostyanko");

        ClientDelegateProgram clientDelegateProgram = new ClientDelegateProgram();
        clientDelegateProgram.Run();

        ClientEventProgram clientEventProgram = new ClientEventProgram();
        clientEventProgram.Run();
    }

    private static void ShowMessage(string firstname, string lastname)
    {
        Console.WriteLine($"{firstname} {lastname} Have fun!!!");
    }
}
