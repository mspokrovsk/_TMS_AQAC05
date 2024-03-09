using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    // Комплексные
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.ClickLoginInButton();

        return new DashboardPage(Driver);
    }
    
    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }
}