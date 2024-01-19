namespace Event;

public delegate void Notification(string msg);

public interface IManager
{
    event Notification Notified;
}