using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class LoginPage : PageBase
    {
        private static string END_POINT = "";

        // Описание элементов
        private static By usernameField = By.Id("user-name");
        private static By passwordField = By.Id("password");
        private static By loginButton = By.CssSelector(".btn_action");
        private static By textError = By.XPath("//h3[@data-test='error']");

        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }


        // Методы
        public IWebElement UsernameField => WaitsHelper.WaitForExists(usernameField);
        public IWebElement PasswordField => WaitsHelper.WaitForExists(passwordField);
        public IWebElement LoginButton => WaitsHelper.WaitForExists(loginButton);
        public IWebElement TextError => WaitsHelper.WaitForExists(textError);

        // Комплексные
        public ProductsPage SuccessfulLogin(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return new ProductsPage(Driver, true);
        }
        public LoginPage IncorrectLogin(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
            return this;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginButton.Displayed && UsernameField.Displayed;
        }
    }
}
