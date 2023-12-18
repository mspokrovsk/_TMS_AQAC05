using Interfaces.Example;

namespace Interfaces.BaseImpl;

public abstract class Device : IDisplayable
{
    public abstract void DisplayInformation(string information);
}