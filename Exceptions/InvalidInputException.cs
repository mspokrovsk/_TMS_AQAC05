namespace Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(string fieldName, string message)
        : base($"Неверный ввод в поле '{fieldName}': {message}")
    {
    }
}