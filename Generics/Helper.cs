namespace Generics;

public static class Helper
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T tmp = x;
        x = y;
        y = tmp;
        //(x, y) = (y, x);
    }
    
    public static void SendMessage(Message message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }

    /*
    public static void SendMessage<T>(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}"); // ! Ошибка - свойство Text
    }
    */

    public static void SendMessage<T>(T message) where T : Message
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}