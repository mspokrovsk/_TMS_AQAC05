using OpenQA.Selenium;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements;

public class RadioButton
{
    private List<UIElement> _uiElements; // Поле для хранения списка UIElement
    private List<string> _values; // Поле для хранения списка значений
    private List<string> _texts; // Поле для хранения списка текстовых значений

    /// <summary>
    /// Локатор данного элемента должен использовать атрибут name
    /// </summary>
    /// <param name="webDriver"></param>
    /// <param name="by"></param>
    public RadioButton(IWebDriver webDriver, By by) // Публичный конструктор с параметрами webDriver и by
    {
        _uiElements = new List<UIElement>(); // Инициализация списка UIElement
        _values = new List<string>(); // Инициализация списка значений
        _texts = new List<string>(); // Инициализация списка текстовых значений

        WaitsHelper _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout)); // Создание экземпляра WaitsHelper

        foreach (var webElement in _waitsHelper.WaitForPresenceOfAllElementsLocatedBy(by)) // Цикл по всем элементам, найденным по локатору by
        {
            UIElement uiElement = new UIElement(webDriver, webElement); // Создание экземпляра UIElement для каждого найденного элемента
            _uiElements.Add(uiElement); // Добавление элемента в список UIElement
            _values.Add(uiElement.GetAttribute("value")); // Добавление значения атрибута "value" в список значений
            _texts.Add(uiElement.FindUIElement(By.XPath("parent::*/strong")).Text.Trim()); // Добавление текстового значения в список текстовых значений
        }
    }

    public void SelectByIndex(int index) // Метод выбора по индексу
    {
        if (index < _uiElements.Count)
        {
            _uiElements[index].Click();
        }
        else
        {
            throw new AssertionException("Превышен индекс");
        }
    }

    public void SelectByValue(string value) // Метод выбора по значению
    {
        _uiElements[_values.IndexOf(value)].Click();
    }

    public void SelectByText(string text) // Метод выбора по тексту
    {
        var index = _texts.IndexOf(text);
        _uiElements[index].Click();
    }

    public List<string> GetOptions() // Метод получения всех доступных опций радиокнопок
    {
        return _texts;
    }
}