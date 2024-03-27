using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;
using NUnit.Framework;
using System.Threading;

namespace Wrappers.Tests
{
    public class DropDownMenuTest : BaseTest
    {
        [Test]
        public void DropDownTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);

            addTestCasePage.SectionDropDown.SelectOptionByIndex(0);
            addTestCasePage.TemplateDropDown.SelectOptionByText("Exploratory Session");

            Assert.Multiple(() =>
            {
                Assert.That(addTestCasePage.SectionDropDownText.Text.Trim(), Is.EqualTo("Test Cases"), "Selected text does not match");
                Assert.That(addTestCasePage.TemplateDropDownText.Text.Trim(), Is.EqualTo("Exploratory Session"), "Selected text does not match");
            });
        }

    }
}