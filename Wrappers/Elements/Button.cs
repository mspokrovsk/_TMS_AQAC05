using OpenQA.Selenium;

namespace Wrappers.Elements;

public class Button
{
    private UIElement _uiElement; // Поле для хранения экземпляра UIElement

    public Button(IWebDriver webDriver, By by) // Публичный конструктор с параметрами webDriver и by
    {
        _uiElement = new UIElement(webDriver, by);
    }
     
    public Button(IWebDriver webDriver, IWebElement webElement) // Публичный конструктор с параметрами webDriver и webElement
    {
        _uiElement = new UIElement(webDriver, webElement);
    }

    public void Click() // Метод для клика по кнопке, делегирует действие UIElement
    {
        _uiElement.Click();
    }

    public void Submit() // Метод для отправки формы, делегирует действие UIElement
    {
        _uiElement.Submit();
    }

    public string Text => _uiElement.Text; // Свойство для получения текстового содержимого кнопки
    public bool Displayed => _uiElement.Displayed; // Свойство, указывающее, отображается ли кнопка на странице
}