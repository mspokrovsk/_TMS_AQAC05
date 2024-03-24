using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements;

public class UIElement : IWebElement // Объявление класса UIElement, реализующего интерфейс IWebElement
{
    //задаем переменные
    private IWebDriver _webDriver; // Поле для хранения экземпляра веб-драйвера
    private WaitsHelper _waitsHelper; // Поле для хранения экземпляра вспомогательного класса ожиданий
    private IWebElement _webElement; // Поле для хранения веб-элемента
    private Actions _actions; // Поле для хранения действий с веб-элементами

    private UIElement(IWebDriver webDriver) // Приватный конструктор с параметром webDriver
    {
        _webDriver = webDriver;
        _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        _actions = new Actions(webDriver);
    }

    public UIElement(IWebDriver webDriver, By by) : this(webDriver) // Публичный конструктор с параметрами webDriver и by, вызывает приватный конструктор
    {
        _webElement = _waitsHelper.WaitForExists(by);
    }

    public UIElement(IWebDriver webDriver, IWebElement webElement) : this(webDriver) // Публичный конструктор с параметрами webDriver и webElement, вызывает приватный конструктор
    {
        _webElement = webElement;
    }

    public IWebElement FindElement(By by) // Метод поиска вложенного элемента по локатору By
    {
        return _waitsHelper.WaitChildElement(_webElement, by);
    }

    public UIElement FindUIElement(By by) // Метод поиска вложенного элемента типа UIElement по локатору By
    {
        return new UIElement(_webDriver, FindElement(by));
    }

    public ReadOnlyCollection<IWebElement> FindElements(By by) // Метод поиска всех вложенных элементов по локатору By
    {
        return _webElement.FindElements(by);
    }

    public List<UIElement> FindUIElements(By by) // Метод поиска всех вложенных элементов типа UIElement по локатору By
    {
        var result = new List<UIElement>();
        foreach (var webElement in FindElements(by))
        {
            result.Add(new UIElement(_webDriver, webElement));
        }

        return result;
    }

    public void Clear() // Метод очистки текстового поля элемента
    {
        _webElement.Clear();
    }

    public void SendKeys(string text) // Метод ввода текста в текстовое поле элемента
    {
        _webElement.SendKeys(text);
    }

    public void Submit() // Метод отправки формы, если элемент является формой
    {
        _webElement.Submit();
    }

    public void Click() // Метод клика по элементу, обрабатывает ElementNotInteractableException
    {
        try
        {
            _webElement.Click();
        }
        catch (ElementNotInteractableException)
        {
            try
            {
                _actions
                    .MoveToElement(_webElement)
                    .Click()
                    .Build()
                    .Perform();
            }
            catch (Exception)
            {
                MoveToElement();
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].click();", _webElement);
            }
        }
    }

    public string GetAttribute(string attributeName) // Метод получения значения атрибута элемента
    {
        return _webElement.GetAttribute(attributeName);
    }

    public string GetDomAttribute(string attributeName) // Метод получения значения DOM-атрибута элемента
    {
        return _webElement.GetDomAttribute(attributeName);
    }

    public string GetDomProperty(string propertyName) // Метод получения значения DOM-свойства элемента
    {
        return _webElement.GetDomProperty(propertyName);
    }

    public string GetCssValue(string propertyName) // Метод получения значения CSS-свойства элемента
    {
        return _webElement.GetCssValue(propertyName);
    }

    public ISearchContext GetShadowRoot() // Метод получения теневого корня элемента
    {
        return _webElement.GetShadowRoot();
    }

    public void MoveToElement() // Метод перемещения к элементу на странице
    {
        ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", _webElement);
    }

    public void Hover() // Метод наведения курсора на элемент
    {
        _actions.MoveToElement(_webElement).Build().Perform();
    }

    public string TagName => _webElement.TagName; // Свойство для получения имени тега элемента

    public string Text // Свойство для получения текстового содержимого элемента
    {
        get
        {
            /*
            if (_webElement.Text != null || _webElement.Text.Equals(""))
            {
                if (GetAttribute("value").Equals(""))
                {
                    return GetAttribute("innerText");
                }

                return GetAttribute("value");
            }
            */

            return _webElement.Text;
        }
    }

    public bool Enabled => _webElement.Enabled; // Свойство, указывающее, доступен ли элемент для взаимодействия
    public bool Selected => _webElement.Selected; // Свойство, указывающее, выбран ли элемент
    public Point Location => _webElement.Location; // Свойство для получения позиции элемента на странице
    public Size Size => _webElement.Size; // Свойство для получения размеров элемента
    public bool Displayed => _webElement.Displayed; // Свойство, указывающее, отображается ли элемент на странице
}