using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SauceDemo.Pages
{
    internal class CartPage : PageBase
    {
        private static string END_POINT = "cart.html";

        // Описание элементов
        private static By cartItems = By.CssSelector(".cart_item");
        private static By continueShoppingButton = By.CssSelector(".btn_secondary");
        private static By checkoutButton = By.CssSelector(".checkout_button");

        // Инициализация класса
        public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement CartItems => WaitsHelper.WaitForExists(cartItems);
        public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(continueShoppingButton);
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(checkoutButton);

        public override bool IsPageOpened()
        {
            return Driver.Title.Contains("Your Cart");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public void ClickContinueShoppingButton() => ContinueShoppingButton.Click();
        public CheckoutPage ClickCheckoutButton()
        {
            CheckoutButton.Click();
            return new CheckoutPage(Driver, true);
        }
    }
}
