using Allure.Steps;

namespace Allure.Tests;

public class StepsAllureTest : BaseTest
{
    [Test]
    public void TestCreateLabel()
    {
        AllureSteps.TestDomain("https://domain1.example.com/");
        AllureSteps.TestDomain("https://domain2.example.com/");
    }
}