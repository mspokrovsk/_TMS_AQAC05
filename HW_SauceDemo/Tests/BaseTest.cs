using OpenQA.Selenium;
using HW_SauceDemo.Core;
using HW_SauceDemo.Helpers.Configuration;
using NUnit.Allure.Core;
using Allure.Net.Commons;
using System.Text;
using HW_SauceDemo.Helpers;
using HW_SauceDemo.Steps;

namespace HW_SauceDemo.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected AllureSteps AllureSteps;

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        AllureSteps = new AllureSteps(Driver);
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] screenshotBytes = screenshot.AsByteArray;

            // Прикрепление скриншота к отчету
            // Вариант 1
            AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);

        }
        Driver.Quit();
    }
}