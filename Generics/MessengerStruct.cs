namespace Generics;

public class MessengerStruct<T> where T : struct
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
    }
}