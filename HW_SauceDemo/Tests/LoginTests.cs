using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;

namespace HW_SauceDemo.Tests;

public class LoginTests : BaseTest
{
    [Test]
    public void LoginWithStandardUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LoginWithProblemUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin("problem_user", Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened(), "Failed to login with problem_user");
    }

    [Test]
    public void LoginWithErrorUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.IncorrectLogin("error_user", "");
        loginPage.TextError.Text.Trim();
        Is.EqualTo("Epic sadface: Password is required");
    }
}
