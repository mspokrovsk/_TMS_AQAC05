namespace Interfaces.FinalExample;

public class ApplicationTester : ITestable
{
    private Test[] tests = new Test[100];
    private int index = 0;

    public void AddTest(Test test)
    {
        tests[index++] = test;
    }

    public void RunTests()
    {
        for (int i = 0; i < index; i++)
        {
            tests[i].Run();            
        }
    }
}
