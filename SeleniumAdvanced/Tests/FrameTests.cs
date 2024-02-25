using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class FrameTests : BaseTest
{
    [Test]
    public void FrameTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");

        Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mce_0_ifr")));
        //Driver.SwitchTo().Frame(0);
        //Driver.SwitchTo().Frame("mce_0_ifr"); // значение из id или name атрибута 
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("tinymce")).Displayed);

        Driver.SwitchTo().ParentFrame(); // Возврат в родительский фрейм на 1 уровень выше
        Driver.SwitchTo().DefaultContent(); // Возврат в родительский документ на самый первый уровень
        
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.ClassName("tox-editor-container")).Displayed);
    }
}