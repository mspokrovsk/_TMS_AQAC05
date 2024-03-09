using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        UserSteps userSteps = new UserSteps(Driver);
        DashboardPage dashboardPage = userSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        Assert.That(dashboardPage.IsPageOpened);
    }
    
    [Test]
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