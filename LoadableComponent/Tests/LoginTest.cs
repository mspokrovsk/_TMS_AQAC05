using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.Load();
        
        loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        Driver.Navigate().GoToUrl("https://aqa2503.testrail.io/index.php?/mysettings");
        
        DashboardPage dashboardPage = new DashboardPage(Driver);
        dashboardPage.SidebarProjectsAddButton.Click();
    }
}