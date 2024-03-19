using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace HW_SauceDemo.Tests;

[AllureEpic("Web Interface")]
[AllureFeature("Login feature", "AddToCart feature")]

    public class AddItemToCartTest : BaseTest
    {
        [Test(Description = "Проверка успешного отображения значка у корзины после добавления продукта в корзину")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("mspokrovsk")]
        [AllureStory("Story4")]
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

