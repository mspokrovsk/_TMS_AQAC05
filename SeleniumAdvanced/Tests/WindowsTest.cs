using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class WindowsTest : BaseTest
{
    [Test]
    public void NewTabTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/windows");

        string originalWindowHandle = Driver.CurrentWindowHandle;
        
        Driver.FindElement(By.LinkText("Click Here")).Click();

        var windowHandlesSet = Driver.WindowHandles;

        Driver.SwitchTo().Window(windowHandlesSet[1]);
        
        Thread.Sleep(3000);
        
        Assert.That(Driver.FindElement(By.TagName("h3")).Text, Is.EqualTo("New Window"));
        
        Driver.Close();

        Driver.SwitchTo().Window(originalWindowHandle);
        
        Assert.That(Driver.FindElement(By.LinkText("Click Here")).Displayed);
    }
}