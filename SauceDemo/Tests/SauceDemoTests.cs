using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests
{
    public class SauceDemoTests : BaseTest
    {
        [Test]

        public void SearchingForAnElementByLocators()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(3000);
            // id
            Driver.FindElement(By.Id("user-name")).SendKeys(Configurator.AppSettings.Username);
            Thread.Sleep(3000);
            // name
            Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);
            Thread.Sleep(3000);
            // tagname
            Assert.That(Driver.FindElement(By.TagName("input")).Displayed);

            // classname
            Driver.FindElement(By.ClassName("submit-button")).Click();
            Thread.Sleep(3000);

            // linktext
            Assert.That(Driver.FindElement(By.LinkText("Test.allTheThings() T-Shirt (Red)")).Displayed);

            // partiallinktext
            Assert.That(Driver.FindElement(By.PartialLinkText("Labs")).Displayed);

            // xpath
            // 1. ����� �� ��������
            Assert.That(Driver.FindElement(By.XPath("//a[@id='item_3_img_link']")).Displayed);

            // 2. ����� �� ������
            Assert.That(Driver.FindElement(By.XPath("//div[text()='Test.allTheThings() T-Shirt (Red)']")).Displayed);

            // 3. ����� �� ���������� ���������� ��������
            Assert.That(Driver.FindElement(By.XPath("//img[contains(@alt,'Test.allTheThings() T-Shirt (Red)')]")).Displayed);

            // 4. ����� �� ���������� ���������� ������
            Assert.That(Driver.FindElement(By.XPath("//div[contains(text(),'T-Shirt (Red)')]")).Displayed);

            // 5. ancestor
            Assert.That(Driver.FindElement(By.XPath("//*[text()='15.99']//ancestor::div")).Displayed);

            // 6. descendant
            Assert.That(Driver.FindElement(By.XPath("//*[@class='footer']//descendant::div")).Displayed);

            // 7. following
            Assert.That(Driver.FindElement(By.XPath("//*[@class='inventory_item_img']//following::div")).Displayed);

            // 8. parent
            Assert.That(Driver.FindElement(By.XPath("//*[@class='inventory_item_img']//parent::div")).Displayed);

            // 9. preceding
            Assert.That(Driver.FindElement(By.XPath("//*[@class='inventory_item_description']//preceding::div")).Displayed);

            // 10. ����� �������� � �������� AND
            Assert.That(Driver.FindElement(By.XPath("//button[@data-test='add-to-cart-test.allthethings()-t-shirt-(red)' and @name='add-to-cart-test.allthethings()-t-shirt-(red)']")).Displayed);

            // css
            // 1. .class
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_list")).Displayed);

            // 2. .class1.class2
            Assert.That(Driver.FindElement(By.CssSelector(".btn.btn_primary")).Displayed);

            // 3. .class1 .class2
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_container .inventory_list")).Displayed);

            // 4. #id
            Assert.That(Driver.FindElement(By.CssSelector("#item_5_img_link")).Displayed);

            // 5. tagname
            Assert.That(Driver.FindElement(By.CssSelector("img")).Displayed);

            // 6. tagname.class
            Assert.That(Driver.FindElement(By.CssSelector("img.inventory_item_img")).Displayed);

            // 7. [attribute=value]
            Assert.That(Driver.FindElement(By.CssSelector("[name=add-to-cart-sauce-labs-fleece-jacket]")).Displayed);

            // 8. [attribute~=value]
            Assert.That(Driver.FindElement(By.CssSelector("[alt~=Fleece]")).Displayed);

            // 9. [attribute|=value]
            Assert.That(Driver.FindElement(By.CssSelector("[data-test|=add-to-cart-sauce-labs-fleece-jacket]")).Displayed);

            // 10. [attribute^=value]
            Assert.That(Driver.FindElement(By.CssSelector("[data-test^=add]")).Displayed);

            // 11. [attribute$=value]
            Assert.That(Driver.FindElement(By.CssSelector("[data-test$=jacket]")).Displayed);

            // 12. [attribute*=value]
            Assert.That(Driver.FindElement(By.CssSelector("[data-test*=labs]")).Displayed);
        }
    }
}