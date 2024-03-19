using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class CartPage : PageBase
    {
        private static string END_POINT = "cart.html";

        // Описание элементов
        private static By cartItems = By.CssSelector(".cart_item");
        private static By removeButton = By.Id("remove-test.allthethings()-t-shirt-(red)");
        private static By continueShoppingButton = By.CssSelector(".btn_secondary");
        private static By checkoutButton = By.CssSelector(".checkout_button");
        
        // Инициализация класса
        public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement CartItems => WaitsHelper.WaitForExists(cartItems);
        public bool CartItemsInvisibility => WaitsHelper.WaitForElementInvisible(cartItems);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(removeButton);
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
        [AllureStep("Удаление товара из корзины")]
        public void ClickRemoveButton() => RemoveButton.Click();
        [AllureStep("Переход на страницу оформления товара")]
        public CheckoutPage ClickCheckoutButton()
        {
            CheckoutButton.Click();
            return new CheckoutPage(Driver, true);
        }
    }
}
