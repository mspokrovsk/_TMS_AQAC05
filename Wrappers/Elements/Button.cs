using OpenQA.Selenium;

namespace Wrappers.Elements;

public class Button
{
    private UIElement _uiElement; // ���� ��� �������� ���������� UIElement

    public Button(IWebDriver webDriver, By by) // ��������� ����������� � ����������� webDriver � by
    {
        _uiElement = new UIElement(webDriver, by);
    }
     
    public Button(IWebDriver webDriver, IWebElement webElement) // ��������� ����������� � ����������� webDriver � webElement
    {
        _uiElement = new UIElement(webDriver, webElement);
    }

    public void Click() // ����� ��� ����� �� ������, ���������� �������� UIElement
    {
        _uiElement.Click();
    }

    public void Submit() // ����� ��� �������� �����, ���������� �������� UIElement
    {
        _uiElement.Submit();
    }

    public string Text => _uiElement.Text; // �������� ��� ��������� ���������� ����������� ������
    public bool Displayed => _uiElement.Displayed; // ��������, �����������, ������������ �� ������ �� ��������
}