namespace Delegate;

public class Example7
{
    delegate void Message();

    delegate int Operation(int x, int y);
    
    public void Run()
    {
        Message? msg = null;
        msg?.Invoke();

        Operation op = Add;
        int result = op.Invoke(1, 2);

        op -= Add;
        //result = op.Invoke(1, 2);
        int? result1 = op?.Invoke(2, 3);
    }

    private int Add(int x, int y)
    {
      return x + y;
    } 
}