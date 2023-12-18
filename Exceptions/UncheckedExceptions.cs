namespace Exceptions;

public class UncheckedExceptions
{
    // Пример неконтролируемого исключения
    public void DivideNumbers(int a, int b)
    {
        int result = a / b; // Возможно возникновение ArithmeticException
    }
}