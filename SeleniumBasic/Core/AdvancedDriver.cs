using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumBasic.Core;

public class AdvancedDriver
{
    private string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);//путь к драйверу браузера
    
    public IWebDriver GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();//экземпляр класса 
        chromeOptions.AddArguments("--incognito");//запуск в приватном режиме
        chromeOptions.AddArguments("--disable-gpu");//отключаем графический процессор
        chromeOptions.AddArguments("--disable-extensions");//отключение дополнений
        //chromeOptions.AddArguments("--headless");//режим без ui части для ускорения проверки
        
        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);//логирование браузера
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);//логирование драйвера

        return new ChromeDriver(basePath + @"/Resources/", chromeOptions);//запуск браузера
    }

    public IWebDriver GetFirefoxDriver()
    {
        var mimeTypes =
            "image/png,image/gif,image/jpeg,image/pjpeg,application/pdf,text/csv,application/vnd.ms-excel," +
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" +
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            
        var ffOptions = new FirefoxOptions();
        var profile = new FirefoxProfile();
            
        profile.SetPreference("browser.download.folderList", 2);
        profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", mimeTypes);
        profile.SetPreference("browser.helperApps.neverAsk.openFile", mimeTypes);
        ffOptions.Profile = profile;
            
        ffOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        return new FirefoxDriver(ffOptions);
    }
}