using Microsoft.Playwright;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FinalTask.Core;
using FinalTask.Helpers.Configuration;
using FinalTask.Models;

namespace SpecFlowProject3.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly Browser _browser;
        public User Admin {  get; set; }
        public Hooks1(Browser browser)
        {
            _browser = browser;
        }

        [BeforeScenario("GUI")]
        public void BeforeGUIScenario()
        {
            _browser.SetUpDriver();
            _browser.Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [AfterScenario("GUI")]
        public void AfterScenario()
        {
            _browser.Driver.Quit();
        }
    }
}