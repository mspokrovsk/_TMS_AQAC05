using OpenQA.Selenium;

namespace HW_SauceDemo.Pages
{
    internal class CheckoutPageTwo  : PageBase
    {
        private static string END_POINT = "checkout-step-two.html";

        // Описание элементов
        private By productTshirt = By.ClassName("inventory_item_name");
        private By total = By.CssSelector("[class~='summary_total_label']");
        private static By finishButton = By.Id("finish");

        // Инициализация класса
        public CheckoutPageTwo(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        // Методы
        public IWebElement ProductTshirt => WaitsHelper.WaitForExists(productTshirt);
        public IWebElement Total => WaitsHelper.WaitForExists(total);
        public IWebElement FinishButton => WaitsHelper.WaitForExists(finishButton);

        public override bool IsPageOpened()
        {
            return Driver.Title.Contains("Checkout: Overview");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public FinishPage ClickFinishButton()
        {
            FinishButton.Click();
            return new FinishPage(Driver, true);
        }
    }
}
