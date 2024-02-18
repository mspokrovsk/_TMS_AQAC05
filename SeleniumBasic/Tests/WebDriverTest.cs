using OpenQA.Selenium;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;
        webDriver.Manage().Window.Maximize();//управление размерами окна браузера
        webDriver.Navigate().GoToUrl("http://onliner.by");//переход по ссылке
        webDriver.Quit();//убить процесс
    }

    [Test]
    public void AdvancedDriverTest()
    {
        IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();
    }

    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver;
        IWebDriver webDriver1 = new Browser().Driver;
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver1.Manage().Window.Maximize();
        webDriver1.Navigate().GoToUrl("http://onliner.by");

        webDriver.Quit();
        webDriver1.Quit();
    }
}