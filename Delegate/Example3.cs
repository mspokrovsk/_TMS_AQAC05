namespace Delegate;

public class Example3
{
    public delegate void Notification();

    public void Run()
    {
        Notification noPrm = ShowMessage1;

        noPrm = noPrm + ShowMessage2;
        noPrm += ShowMessage1;
        noPrm += ShowMessage2;
        
        noPrm.Invoke();

        noPrm -= ShowMessage1;
        noPrm -= ShowMessage1;
        noPrm -= ShowMessage2;
        noPrm -= ShowMessage2;
        
        noPrm.Invoke();
    }

    private void ShowMessage1() => Console.WriteLine("Have fun!!!");
    
    private void ShowMessage2() => Console.WriteLine("See you!!!");
}