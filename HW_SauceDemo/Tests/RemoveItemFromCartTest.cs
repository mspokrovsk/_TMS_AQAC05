using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;

namespace HW_SauceDemo.Tests
{
    public class RemoveItemFromCartTest : BaseTest
    {
        [Test]
        public void RemoveItemFromCart()
        {
            LoginPage loginPage = new LoginPage(Driver);
            ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(productsPage.IsPageOpened);

            // Добавление товара в корзину
            productsPage.ClickAddToCartBackBackButton();

            // Переход в корзину и удаление товара
            CartPage cartPage = productsPage.ClickShoppingCartLink();
            cartPage.ClickRemoveButton();
                        
            // Проверка успешного удаления товара
            Assert.That(cartPage.CartItemsInvisibility, Is.EqualTo(true));
        }
    }
}
