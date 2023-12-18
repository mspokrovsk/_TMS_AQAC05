namespace Exceptions;

public class CustomArgumentException : ArgumentException
{
    public int Value { get;}
    
    public CustomArgumentException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}