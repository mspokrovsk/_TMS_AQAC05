﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SauceDemo.Pages
{
    internal class CheckoutPage : PageBase
    {
        private static string END_POINT = "checkout-step-one.html";

        // Описание элементов
        private static By firstNameField = By.Id("first-name");
        private static By lastNameField = By.Id("last-name");
        private static By postalCodeField = By.Id("postal-code");
        private static By continueButton = By.CssSelector(".btn_primary.cart_button");

        // Инициализация класса
        public CheckoutPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement FirstNameField => WaitsHelper.WaitForExists(firstNameField);
        public IWebElement LastNameField => WaitsHelper.WaitForExists(lastNameField);
        public IWebElement PostalCodeField => WaitsHelper.WaitForExists(postalCodeField);
        public IWebElement ContinueButton => WaitsHelper.WaitForExists(continueButton);

        public override bool IsPageOpened()
        {
            return Driver.Title.Contains("Checkout: Your Information");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public void FillOutPersonalInfo(string firstName, string lastName, string postalCode)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            PostalCodeField.SendKeys(postalCode);
            ContinueButton.Click();
        }
    }
}
