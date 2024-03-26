using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;
using NUnit.Framework;
using System.Threading;

namespace Wrappers.Tests
{
    public class WrappersTest : BaseTest
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
                Assert.That(addTestCasePage.SectionDropDown.GetSelectedOptionIndex(), Is.EqualTo(0), "Selected index does not match");
                Assert.That(addTestCasePage.TemplateDropDown.GetSelectedOptionText(), Is.EqualTo("Exploratory Session"), "Selected text does not match");
            });
        }

    }
}