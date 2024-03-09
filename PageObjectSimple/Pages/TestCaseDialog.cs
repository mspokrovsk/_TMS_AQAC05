using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class TestCaseDialog : BasePage
{
    public TestCaseDialog(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }
}