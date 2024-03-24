using OpenQA.Selenium;

namespace Wrappers.Elements 
{
    public class DropDownMenu 
    {
        private UIElement _triggerElement; 
        private List<UIElement> _uiElements; 
        private List<string> _texts; 

        public DropDownMenu(IWebDriver driver, By by) // ����������� ������ DropDownMenu
        {
            _triggerElement = new UIElement(driver, by); // ������������� ��������� ��������
            _uiElements = new List<UIElement>(); // ������������� ������ ���������
            _texts = new List<string>(); // ������������� ������ ��������� ��������
        }

        private void OpenDropDownMenu() // ����� �������� ����������� ����
        {
            _triggerElement.Click(); 
        }

        private void PopulateMenuItems() // ����� ���������� ������ ��������� ����������� ����
        {
            foreach (var webElement in _triggerElement.FindUIElements(By.XPath("descendant::li"))) // ���� �� ���� ��������� ������
            {
                _uiElements.Add(webElement); // ���������� �������� � ������
                _texts.Add(webElement.Text.Trim()); // ���������� ���������� �������� � ������
            }
        }

        private void CloseDropDownMenu() // ����� �������� ����������� ����
        {
            _triggerElement.Click(); 
        }

        public void SelectByText(string text) // ����� ������ �� ������
        {
            var index = _texts.IndexOf(text);
            if (index != -1)
            {
                _uiElements[index].Click();
            }
            else
            {
                throw new AssertionException("������� � ��������� ������� �� ������");
            }
        }

        public void SelectByIndex(int index) // ����� ������ �� �������
        {
            if (index < _uiElements.Count)
            {
                _uiElements[index].Click();
            }
            else
            {
                throw new AssertionException("�������� ������");
            }
        }

        public bool Displayed => _triggerElement.Displayed; // ��������, �����������, ������������ �� �������� �������
    }
}
