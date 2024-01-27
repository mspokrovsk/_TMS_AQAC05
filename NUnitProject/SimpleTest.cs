namespace NUnitProject;

public class SimpleTest : PrePostConditionExample
{
    [SetUp]
    public void Setup1()
    {
        Console.WriteLine($"{this}: SetUp1... {++i}");
    }
    
    [Test]
    public void Test()
    {
        Console.WriteLine($"{this}: Test...");
        Assert.Pass();
    }
}