namespace Generics;

public class MessengerNew<T> where T : new()
{
    private T message;

    public MessengerNew()
    {
        // Создаем новый экземпляр типа T с использованием конструктора без параметров
        message = new T();
    }

    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
    }
}