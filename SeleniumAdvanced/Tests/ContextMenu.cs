using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace SeleniumBasic.Tests
{
    public class ContextMenu : BaseTest
    {
        [Test]
        public void TestContextMenu()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");
            // Находим элемент на странице
            IWebElement element = Driver.FindElement(By.Id("hot-spot"));

            // Выполняем правый клик по элементу
            Actions actions = new Actions(Driver);
            actions.ContextClick(element).Perform();
            
            // Валидируем текст на алерте
            IAlert alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
            
            // Закрываем алерт
            alert.Accept();
        }
    }
}
