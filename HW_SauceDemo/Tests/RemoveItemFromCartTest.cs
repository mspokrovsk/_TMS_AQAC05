using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace HW_SauceDemo.Tests;

[AllureEpic("Web Interface")]
[AllureFeature("Login feature", "AddToCart feature", "Remove feature")]

public class RemoveItemFromCartTest : BaseTest
{
    [Test(Description = "Проверка отсутствия карточки товара на странице после нажатия кнопки Remove")]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureOwner("mspokrovsk")]
    [AllureStory("Story5")]
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
