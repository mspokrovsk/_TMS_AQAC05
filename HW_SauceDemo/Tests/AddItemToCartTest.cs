using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;

namespace HW_SauceDemo.Tests
{
    public class AddItemToCartTest : BaseTest
    {
        [Test]
        public void AddItemToCart()
        {
            LoginPage loginPage = new LoginPage(Driver);
            ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(productsPage.IsPageOpened);

            // Добавление товара в корзину
            productsPage.ClickAddToCartBackBackButton();

            // Проверка успешного добавления товара
            Assert.That(productsPage.CartBadge.Displayed, "Item was not added to the cart");
        }
    }
}
