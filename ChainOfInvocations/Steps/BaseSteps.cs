using OpenQA.Selenium;
using PageObjectSteps.Pages;
using PageObjectSteps.Pages.ProjectPages;

namespace PageObjectSteps.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;
    
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}