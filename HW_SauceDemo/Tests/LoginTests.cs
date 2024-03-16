using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;
using NUnit.Allure.Core;

namespace HW_SauceDemo.Tests;

public class LoginTests : BaseTest
{
    [Test(Description = "Проверка перехода на страницу с продуктами после логина с данными Username=standard_user Password=secret_sauce")]
    public void LoginWithStandardUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test(Description = "Проверка перехода на страницу с продуктами после логина с данными Username=problem_user Password=secret_sauce")]
    public void LoginWithProblemUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin("problem_user", Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened(), "Failed to login with problem_user");
    }

    [Test(Description = "Проверка отображения ошибки Epic sadface: Password is required после логина с данными Username=standard_user Password=")]
    public void LoginWithErrorUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.IncorrectLogin("error_user", "");
        loginPage.TextError.Text.Trim();
        Is.EqualTo("Epic sadface: Password is required");
    }
}
