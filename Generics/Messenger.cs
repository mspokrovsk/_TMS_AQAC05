namespace Generics;

public class Messenger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}