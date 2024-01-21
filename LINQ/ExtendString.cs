namespace LINQ;

public static class ExtendString
{
    public static char GetChar(this string value, int index)
    {
        return value[index];
    }
}