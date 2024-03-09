using OpenQA.Selenium;
using SeleniumBasic.Helpers;
using SeleniumBasic.Helpers.Configuration;

namespace SeleniumBasic.Pages;

public abstract class BasePage
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    
    public BasePage(IWebDriver driver, bool openPageByUrl = false)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        if (openPageByUrl)
        {
            OpenPageByURL();
        }
    }
    
    protected abstract string GetEndpoint();
    public abstract bool IsPageOpened();
    
    protected void OpenPageByURL()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}