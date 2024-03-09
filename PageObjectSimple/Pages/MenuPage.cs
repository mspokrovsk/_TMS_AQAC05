using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class MenuPage : BasePage
{
    private static string END_POINT = "";

    // Описание элементов
    private static readonly By WorkingOnMenuBy = By.Id("inProgressLink");

    
    public MenuPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return WorkingOnMenu.Displayed;
    }
    
    // Методы
    public IWebElement WorkingOnMenu => WaitsHelper.WaitForExists(WorkingOnMenuBy);  
}