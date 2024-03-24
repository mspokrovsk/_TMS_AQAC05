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
        ToggleCheckbox(true); // �������� ����� ToggleCheckbox � ������ true ��� ��������� ��������
    }

    public void RemoveCheckbox()
    {
        ToggleCheckbox(false); // �������� ����� ToggleCheckbox � ������ false ��� ������ ��������
    }

    public void ToggleCheckbox(bool flag) //����� ��� ������������ ��������� �������� � ����������� �� ����������� �����
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
        return string.IsNullOrEmpty(afterAttributeValue); //������ true ���� �������� ������

    }
}