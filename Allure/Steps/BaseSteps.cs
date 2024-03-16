using OpenQA.Selenium;

namespace Allure.Steps;

public class BaseSteps
{
    protected IWebDriver Driver;

    public BaseSteps(IWebDriver driver)
    {
        Driver = driver;
    }
}