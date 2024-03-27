using OpenQA.Selenium;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;
using System;
using System.Collections.Generic;

namespace Wrappers.Elements
{
    public class DropDownMenu
    {
        private UIElement _mainElement;
        private List<UIElement> _uiElements;
        private List<string> _texts;

        public DropDownMenu(IWebDriver driver, By by)

        {
            _mainElement = new UIElement(driver, by);
            _uiElements = new List<UIElement>();
            _texts = new List<string>();

            ToggleDropDown();
            PopulateElements();
            ToggleDropDown();
        }

        public void SelectOptionByText(string text)
        {
            ToggleDropDown();
            try
            {
                _uiElements[_texts.IndexOf(text)].Click();
            }
            catch (Exception e)
            {
                throw new AssertionException("Element not found for the searched text: " + text);
            }
        }

        public void SelectOptionByIndex(int index)
        {
            ToggleDropDown();
            try
            {
                _uiElements[index].Click();
            }
            catch (Exception e)
            {
                throw new AssertionException("Element not found for the searched index: " + index);
            }
        }

        public bool IsDisplayed => _mainElement.Displayed;

        private void ToggleDropDown()
        {
           //Thread.Sleep(2000);
           _mainElement.Click();
        }

        private void PopulateElements()
        {
            foreach (var webElement in _mainElement.FindUIElements(By.XPath("descendant::li")))
            {
                _uiElements.Add(webElement);
                _texts.Add(webElement.Text.Trim());
            }
        }

    }
}
