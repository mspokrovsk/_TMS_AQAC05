using OpenQA.Selenium;
using SeleniumBasic.Helpers;

namespace SeleniumBasic.Tests;

public class WaitsTest : BaseTest
{
    [Test]
    public void PresenceOfElementTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();
        
        Assert.That(!button.Displayed);

        IWebElement loading = Driver.FindElement(By.Id("loading"));
        Assert.That(loading.Displayed);
        Thread.Sleep(10000);
        Assert.That(!loading.Displayed);
        
        Assert.That(Driver.FindElement(By.Id("finish")).Displayed);
    }

    [Test]
    public void PresenceOfElementTest1()
    {
        WaitsHelper waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(30));
        
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = waitsHelper.WaitForVisibilityLocatedBy(By.TagName("button"));
        button.Click();
        
        Assert.That(waitsHelper.WaitForElementInvisible(By.TagName("button")));

        IWebElement loading = waitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.That(loading.Displayed);
        
        Assert.That(waitsHelper.WaitForElementInvisible(By.Id("loading")));
        
        Assert.That(waitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }

    [Test]
    public void PresenceOfElementTest2()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = WaitsHelper.FluentWaitForElement(By.TagName("button"));
        button.Click();
        
        Assert.That(WaitsHelper.WaitForElementInvisible(button));

        IWebElement loading = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.That(loading.Displayed);
        
        Assert.That(WaitsHelper.WaitForElementInvisible(loading));
        
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
}