using OpenQA.Selenium;
using HW_SauceDemo.Helpers;
using HW_SauceDemo.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SauceDemo.Pages
{
    internal abstract class PageBase
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
            WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }

        public PageBase(IWebDriver driver, bool openPageByUrl) : this(driver)
        {
            if (openPageByUrl)
            {
                OpenPageByURL();
            }
        }

        protected abstract string GetEndpoint();
        public abstract bool IsPageOpened();
        protected void OpenPageByURL()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
