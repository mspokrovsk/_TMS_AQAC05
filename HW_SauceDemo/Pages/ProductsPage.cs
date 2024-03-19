using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class ProductsPage : PageBase
    {
        private static string END_POINT = "inventory.html";

        // Описание элементов
        private static By products = By.ClassName("title");
        private static By productName = By.CssSelector(".inventory_item_name");
        private static By addToCartButton = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        private static By cartBadge = By.CssSelector(".shopping_cart_badge");
        private static By removeButton = By.Id("remove-test.allthethings()-t-shirt-(red)");
        
        // Инициализация класса
        public ProductsPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement Products => WaitsHelper.WaitForExists(products);
        public IWebElement ProductName => WaitsHelper.WaitForExists(productName);
        public IWebElement AddToCartButton => WaitsHelper.WaitForExists(addToCartButton);
        public IWebElement CartBadge => WaitsHelper.WaitForExists(cartBadge);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(removeButton);
        
        public override bool IsPageOpened()
        {
            return Products.Text.Trim().Equals("Products");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
        [AllureStep("Добавление товара в корзину")]
        public void ClickAddToCartBackBackButton() => AddToCartButton.Click();
        [AllureStep("Переход на страницу корзины")]
        public CartPage ClickShoppingCartLink()
        {
            CartBadge.Click();
            return new CartPage(Driver, true);
        }
    }
}
