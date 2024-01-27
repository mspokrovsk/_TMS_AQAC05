namespace NUnitProject;

public class PrePostConditionExample
{
    protected int i = 0;
        
    [OneTimeSetUp] //создаем пользователя
    public void OnetimeSetup()
    {
        Console.WriteLine($"{this}: OneTimeSetUp... {++i}");
    }

    [SetUp] //открыть браузер
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp... {++i}");
    }
    
    [Test]
    public void Test1()
    {
        Console.WriteLine($"{this}: Test1... {++i}");
    }

    [Test]
    public void Test2()
    {
        Console.WriteLine($"{this}: Test2... {++i}");
    }

    [Test]
    public void Test11()
    {
        Console.WriteLine($"{this}: Test2... {++i}");
    }
    
    [TearDown]//закрыл браузер
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown... {++i}");
    }

    [OneTimeTearDown]//удалить пользователя
    public void FinishTests()
    {
        Console.WriteLine($"{this}: OneTimeTearDown... {++i}");
    }
}