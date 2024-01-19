namespace Event;

public class NotificationHelper
{
    public void NotifyByEmail(string email)
    {
        Console.WriteLine($"Notification was send with message {email}");
    }
}