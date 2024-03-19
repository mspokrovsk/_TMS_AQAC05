using HW_SauceDemo.Pages;
using HW_SauceDemo.Helpers.Configuration;
using NUnit.Allure.Core;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace HW_SauceDemo.Tests;

[AllureEpic("Web Interface")]
[AllureFeature("Login feature")]

public class LoginTests : BaseTest
{
    [Test(Description = "Проверка перехода на страницу с продуктами после логина с данными Username=standard_user Password=secret_sauce")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("mspokrovsk")]
    [AllureStory("Story1")]
    public void LoginWithStandardUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test(Description = "Проверка перехода на страницу с продуктами после логина с данными Username=problem_user Password=secret_sauce")]
    [AllureSeverity(SeverityLevel.minor)]
    [AllureOwner("mspokrovsk")]
    [AllureStory("Story2")]
    public void LoginWithProblemUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage = loginPage.SuccessfulLogin("problem_user", Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened(), "Failed to login with problem_user");
    }

    [Test(Description = "Проверка отображения ошибки Epic sadface: Password is required после логина с данными Username=standard_user Password=")]
    [AllureSeverity(SeverityLevel.blocker)]
    [AllureOwner("mspokrovsk")]
    [AllureIssue("TMS-123")]
    [AllureTms("Req-456")]
    [AllureLink("github", "https://github.com/mspokrovsk/_TMS_AQAC05/blob/Allure_HW/HW_SauceDemo/Tests/LoginTests.cs")]
    [AllureStory("Story3")]
    public void LoginWithErrorUser()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.IncorrectLogin("error_user", "");
        string errorLabelText = loginPage.GetErrorLabelText();
        Assert.That(errorLabelText, Is.EqualTo("Epic sadface: Username is required"));//Проверка на скриншот в неуспешном тесте
    }
}
