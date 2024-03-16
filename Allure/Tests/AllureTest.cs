using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class AllureTest : BaseTest
{
    [Test(Description = "Some detailed test description")]
    public void TestDescription()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestSeverity()
    {
        Assert.That(true);
    }

    [Test]
    [AllureOwner("Alex Trostyanko")]
    public void TestOwner()
    {
        Assert.That(true);
    }

    [Test]
    [AllureIssue("TMS-123")]
    [AllureIssue("TMS-456")]
    public void TestIssue()
    {
        Assert.That(false);
    }

    [Test]
    [AllureTms("Req-123")]
    [AllureTms("Req-456")]
    public void TestTMS()
    {
        Assert.That(true);
    }

    [Test]
    [AllureLink("website", "http://onliner.by")]
    public void TestLink()
    {
        Assert.That(true);
    }
}