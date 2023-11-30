namespace Classes;

public class ConstructorFull
{
    public int sizeMain;
    public string textMain;

    public ConstructorFull()
    {
        sizeMain = 0;
        textMain = String.Empty;
    }

    public ConstructorFull(int size)
    {
        sizeMain = size;
    }

    public ConstructorFull(string text)
    {
        textMain = text;
    }

    public ConstructorFull(int size, string text)
    {
        sizeMain = size;
        textMain = text;
    }
}