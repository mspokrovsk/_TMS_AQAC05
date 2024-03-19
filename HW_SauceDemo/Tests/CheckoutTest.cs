using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;
using HW_SauceDemo.Tests;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace HW_SauceDemo.Tests;

[AllureEpic("Web Interface")]
[AllureFeature("Login feature", "AddToCart feature", "Checkout feature")]

public class CheckoutTest : BaseTest
{
    [Test(Description = "Проверка отображения текста Checkout: Complete! на странице после нажатия кнопки Finish")]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureOwner("mspokrovsk")]
    [AllureStory("Story6")]
    public void CompleteCheckoutProcess()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);

        // Добавление товара в корзину
        productsPage.ClickAddToCartBackBackButton();

        // Переход в корзину
        CartPage cartPage = productsPage.ClickShoppingCartLink();
        //Assert.That(cartPage.IsPageOpened);

        // Переход к оформлению заказа
        CheckoutPage checkoutPage = cartPage.ClickCheckoutButton();

        // Заполнение персональной информации
        CheckoutPageTwo checkoutPageTwo = checkoutPage.FillOutPersonalInfo("Mary", "Pokrovskaya", "620026");

        // Проверка отображения цены
        Assert.That(checkoutPageTwo.Total.Text.Trim(), Is.EqualTo("Total: $17.27"));

        // Переход к завершению заказа
        FinishPage finishPage = checkoutPageTwo.ClickFinishButton();

        // Проверка завершения заказа
        Assert.That(finishPage.CheckoutComplete.Text.Trim(), Is.EqualTo("Checkout: Complete!"));
        Assert.That(finishPage.BackHomeButtonVisible, Is.EqualTo(true));
    }
}
