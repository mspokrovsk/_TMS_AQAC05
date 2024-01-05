namespace Generics;

public class MessengerClass<T> where T : class
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
    }
}