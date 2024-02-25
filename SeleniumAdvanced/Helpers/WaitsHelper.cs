using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumBasic.Helpers;

public class WaitsHelper(IWebDriver driver, TimeSpan timeout)
{
    private readonly WebDriverWait _wait = new(driver, timeout);

    public IWebElement WaitForVisibilityLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementIsVisible(locator));//ждем пока элемент станет видимым
    }

    public ReadOnlyCollection<IWebElement> WaitForAllVisibleElementsLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
    }

    public IWebElement WaitForExists(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementExists(locator));//ждем пока элемент будет в DOM
    }

    public bool WaitForElementInvisible(By locator)//пока элемент станет невидимым
    {
        return _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
    }

    public bool WaitForElementInvisible(IWebElement webElement)//создаем свой метод ожидания
    {
        try
        {
            // Проверка, видим ли элемент
            return _wait.Until(d => !webElement.Displayed);
        }
        catch (NoSuchElementException)
        {
            // Если элемент не найден, считаем его невидимым
            return true;
        }
        catch (StaleElementReferenceException)
        {
            // Если элемент устарел, считаем его невидимым
            return true;
        }
        catch (WebDriverTimeoutException)
        {
            throw new WebDriverTimeoutException("Элемент не стал невидимым в течение заданного времени");
        }
    }
    
    public bool WaitForVisibility(IWebElement element)//свой метод элегантное решение выше
    {
        return _wait.Until(_ => element.Displayed);
    }

    public IWebElement FluentWaitForElement(By locator)
    {
        // Инициализация и параметризация FluentWait
        WebDriverWait fluentWait = new WebDriverWait(driver, TimeSpan.FromSeconds(12))
        {
            PollingInterval = TimeSpan.FromMilliseconds(50)//через сколько проверять условия
        };
        
        fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));//игнор эксепшенов
        
        // Использование
        return fluentWait.Until(_ => driver.FindElement(locator));
    }
}