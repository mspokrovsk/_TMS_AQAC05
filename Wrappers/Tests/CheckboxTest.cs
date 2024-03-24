using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;
using Wrappers.Steps;

namespace Wrappers.Tests
{
    public class CheckBoxTest : BaseTest
    {
        [Test]
        public void SetCheckBox()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);

            addProjectPage.Checkbox.SetCheckbox();

            Assert.That(addProjectPage.Checkbox.IsSelected);

        }

        [Test]
        public void RemoveCheckBox()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);

            addProjectPage.Checkbox.RemoveCheckbox();

            Assert.That(addProjectPage.Checkbox.IsSelected);

        }
    }
}