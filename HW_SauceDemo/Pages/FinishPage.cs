using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class FinishPage  : PageBase
    {
        private static string END_POINT = "checkout-complete.html";

        // Описание элементов
        private static By checkoutComplete = By.ClassName("title");
        private By completeHeader = By.ClassName("complete-header");
        private By backHomeButton = By.Id("back-to-products");

        // Инициализация класса
        public FinishPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement CheckoutComplete => WaitsHelper.WaitForExists(checkoutComplete);
        public IWebElement CompleteHeader => WaitsHelper.WaitForExists(completeHeader);
        public IWebElement BackHomeButton => WaitsHelper.WaitForExists(backHomeButton);
        public bool BackHomeButtonVisible => WaitsHelper.WaitForVisibility(BackHomeButton);

        public ProductsPage ReturnHomePage()
        {
            BackHomeButton.Click();
            return new ProductsPage(Driver, true);
        }
        [AllureStep("Checkout: Complete!")]
        public override bool IsPageOpened()
        {
            return CheckoutComplete.Text.Trim().Equals("Checkout: Complete!");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
