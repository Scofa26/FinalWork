using Microsoft.Playwright;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FinalTask.Core;
using FinalTask.Helpers.Configuration;
using FinalTask.Models;
using Allure.Net.Commons;
using NUnit.Framework;

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
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    Screenshot screenshot = ((ITakesScreenshot)_browser.Driver).GetScreenshot();
                    byte[] screenshotBytes = screenshot.AsByteArray;

                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            _browser.Driver.Quit();
        }
    }
}