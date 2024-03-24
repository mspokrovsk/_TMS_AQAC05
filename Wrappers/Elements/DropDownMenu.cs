using OpenQA.Selenium;

namespace Wrappers.Elements 
{
    public class DropDownMenu 
    {
        private UIElement _triggerElement; 
        private List<UIElement> _uiElements; 
        private List<string> _texts; 

        public DropDownMenu(IWebDriver driver, By by) // Конструктор класса DropDownMenu
        {
            _triggerElement = new UIElement(driver, by); // Инициализация основного элемента
            _uiElements = new List<UIElement>(); // Инициализация списка элементов
            _texts = new List<string>(); // Инициализация списка текстовых значений
        }

        private void OpenDropDownMenu() // Метод открытия выпадающего меню
        {
            _triggerElement.Click(); 
        }

        private void PopulateMenuItems() // Метод заполнения списка элементов выпадающего меню
        {
            foreach (var webElement in _triggerElement.FindUIElements(By.XPath("descendant::li"))) // Цикл по всем элементам списка
            {
                _uiElements.Add(webElement); // Добавление элемента в список
                _texts.Add(webElement.Text.Trim()); // Добавление текстового значения в список
            }
        }

        private void CloseDropDownMenu() // Метод закрытия выпадающего меню
        {
            _triggerElement.Click(); 
        }

        public void SelectByText(string text) // Метод выбора по тексту
        {
            var index = _texts.IndexOf(text);
            if (index != -1)
            {
                _uiElements[index].Click();
            }
            else
            {
                throw new AssertionException("Элемент с указанным текстом не найден");
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

        public bool Displayed => _triggerElement.Displayed; // Свойство, указывающее, отображается ли основной элемент
    }
}
