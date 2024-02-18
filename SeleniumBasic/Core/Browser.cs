using OpenQA.Selenium;
using SeleniumBasic.Utilites.Configuration;

namespace SeleniumBasic.Core
{
    public class Browser
    {
        public IWebDriver? Driver { get; }//свойство

        public Browser()//конструктор
        {
            Driver = Configurator.BrowserType?.ToLower() switch//связь с файлом configurator из папки utilites
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _ => Driver
            };

            Driver?.Manage().Window.Maximize();
            Driver?.Manage().Cookies.DeleteAllCookies();
            //Driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}