namespace NUnitTest;

public class TestFormatting
{
    #region Login Functionality
    [Test, Order(1)]
    [Description("Verify when correct credentials was used.")]
    [Category("Smoke")]
    public void SuccessfulLoginTest()
    {
        Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}...");
    }

    [Test, Order(2)]
    [Description("Verify when incorrect password was used.")]
    [Category("Regression")]
    public void IncorrectPasswordTest()
    {
        Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}...");
    }

    [Test, Order(2)]
    [Description("Verify when incorrect username was used.")]
    [Category("Regression")]
    public void IncorrectUsernameTest()
    {
        Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}...");
    }
    #endregion

    #region Login Page Elements
    [Test, Order(3)]
    [Description("Verify that all elements are displayed.")]
    [Category("Regression")]
    public void GuiElementsTest()
    {
        Console.WriteLine($"{this}: {TestContext.CurrentContext.Test.MethodName}...");
    }
    #endregion
}