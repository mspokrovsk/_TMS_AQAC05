using OpenQA.Selenium;
using HW_SauceDemo.Core;
using HW_SauceDemo.Helpers;
using HW_SauceDemo.Helpers.Configuration;

namespace HW_SauceDemo.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}