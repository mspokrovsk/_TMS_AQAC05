using OpenQA.Selenium;
using SeleniumBasic.Core;
using SeleniumBasic.Helpers;
using SeleniumBasic.Helpers.Configuration;

namespace SeleniumBasic.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
        
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}