using OpenQA.Selenium;

namespace Wrappers.Elements;

public class Checkbox
{
    private UIElement _uiElement;

    public Checkbox(IWebDriver webDriver, By by)
    {
        _uiElement = new UIElement(webDriver, by);
    }

    public Checkbox(IWebDriver webDriver, IWebElement webElement)
    {
        _uiElement = new UIElement(webDriver, webElement);
    }

    public void Click()
    {
        _uiElement.Click();
    }

    public void SetCheckbox()
    {
        ToggleCheckbox(true); // Вызываем метод ToggleCheckbox с флагом true для установки чекбокса
    }

    public void RemoveCheckbox()
    {
        ToggleCheckbox(false); // Вызываем метод ToggleCheckbox с флагом false для снятия чекбокса
    }

    public void ToggleCheckbox(bool flag) //Метод для переключения состояния чекбокса в зависимости от переданного флага
    {
        if (IsSelected() == flag) 
        {
            _uiElement.Click();
        }
    }

    public bool Displayed => _uiElement.Displayed;
    public bool Enabled => _uiElement.Enabled;

    public bool IsSelected ()
    {
        string afterAttributeValue = _uiElement.GetAttribute("::after");
        return string.IsNullOrEmpty(afterAttributeValue); //вернет true если значение пустое

    }
}