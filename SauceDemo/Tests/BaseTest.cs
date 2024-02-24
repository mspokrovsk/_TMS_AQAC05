using NUnit.Framework;
using SauceDemo.Helpers.Configuration;
using OpenQA.Selenium;
using SauceDemo.Core;

namespace SauceDemo.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
        
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}