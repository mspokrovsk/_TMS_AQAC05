using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    public class FramesTest : BaseTest
    {
        [Test]
        public void TestFrames()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");

            // Открываем iFrame
            var link = WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("iFrame"));
            link.Click();
            IWebElement frame = Driver.FindElement(By.Id("mce_0_ifr"));
            Driver.SwitchTo().Frame(frame);

            // Проверяем, что текст внутри параграфа равен “Your content goes here.”
            IWebElement paragraph = WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("p"));
            Assert.That(paragraph.Text, Is.EqualTo("Your content goes here."));
        }
    }
}
