using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumBasic.Helpers;
using System.Linq.Expressions;

namespace SeleniumBasic.Tests
{
    public class DynamicControls : BaseTest
    {
        [Test]
        public void TestDynamicControls()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");
            // Нажимаем на кнопку Remove около чекбокса
            IWebElement checkbox = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='checkbox']"));
            IWebElement removeButton = Driver.FindElement(By.CssSelector("#checkbox-example button"));
            removeButton.Click();

            // Дожидаемся надписи "It’s gone"
            IWebElement message = WaitsHelper.FluentWaitForElement(By.Id("message"));
            Assert.That(message.Text, Is.EqualTo("It's gone!"));

            // Проверяем, что чекбокса нет
            
            Assert.That(WaitsHelper.WaitForElementInvisible(checkbox));

            // Находим input и проверяем, что он disabled
            IWebElement input = Driver.FindElement(By.CssSelector("#input-example input"));
            Assert.That(!input.Enabled);

            // Нажимаем на кнопку
            IWebElement enableButton = Driver.FindElement(By.CssSelector("#input-example button"));
            enableButton.Click();

            // Дожидаемся надписи "It's enabled!"
            IWebElement messageEnabled = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message"));
            Assert.That(messageEnabled.Text, Is.EqualTo("It's enabled!")); 

            // Проверяем, что input enabled
            Assert.That(input.Enabled);
        }
    }
}
