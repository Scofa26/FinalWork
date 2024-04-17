﻿using FinalTask.Helpers;
using FinalTask.Helpers.Configuration;
using OpenQA.Selenium;


namespace FinalTask.Pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get;  set; }
        public WaitHelpers WaitHelpers { get;  set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitHelpers = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }

        public BasePage(IWebDriver driver, bool openPageByUrl) : this(driver)
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
