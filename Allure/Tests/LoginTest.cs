using Allure.Helpers.Configuration;
using Allure.Pages;
using Allure.Steps;

namespace Allure.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage _loginPage = new LoginPage(Driver);
        _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
        _loginPage.ClickLoginInButton();

        DashboardPage dashboardPage = new DashboardPage(Driver);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void SuccessfulLoginTest1()
    {
        UserSteps userSteps = new UserSteps(Driver);
        DashboardPage dashboardPage = userSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    //[Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new UserSteps(Driver)
                .IncorrectLogin("ssdd", "")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}