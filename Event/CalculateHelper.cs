namespace Event;

public class CalculateHelper
{
    public int CalcDiscount(ClientType clientType)
    {
        if (clientType == ClientType.Corporate) return 10;

        return 20;
    }
}