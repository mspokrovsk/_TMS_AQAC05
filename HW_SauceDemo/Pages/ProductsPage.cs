using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class ProductsPage : PageBase
    {
        private static string END_POINT = "inventory.html";

        // Описание элементов
        private static By products = By.ClassName("title");
        private static By productName = By.CssSelector(".inventory_item_name");
        private static By addToCartButton = By.CssSelector(".btn_inventory");
        private static By cartBadge = By.CssSelector(".shopping_cart_badge");
        private static By removeButton = By.CssSelector(".btn_secondary");
        private static By checkoutButton = By.CssSelector(".checkout_button");

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
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(checkoutButton);

        public override bool IsPageOpened()
        {
            return Products.Text.Trim().Equals("Products");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public void ClickAddToCartBackBackButton() => CheckoutButton.Click();
        public CartPage ClickShoppingCartLink()
        {
            CartBadge.Click();
            return new CartPage(Driver, true);
        }
    }
}
