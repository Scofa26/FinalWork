using Allure.Net.Commons;
using FinalTask.Core;
using FinalTask.Helpers.Configuration;
using FinalTask.Models;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace FinalTask.Tests
{

    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected User Admin { get; private set; }

        [OneTimeSetUp]
        public static void GlobalSetUo()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new Browser().Driver;
            
            Admin = new User

            {
                Email = Configurator.AppSettings.Username,
                Password = Configurator.AppSettings.Password
            };
            Driver.Navigate().GoToUrl("https://mtswork.testmo.net/");
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                    byte[] screenshotBytes = screenshot.AsByteArray;

                    //Скриншот конкретного эл-та
                    // IWebElement test = Driver.FindElement(By.Id("dss"));
                    //Screenshot screenshot1 = ((ITakesScreenshot)Driver).GetScreenshot();

                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Driver.Quit();
        }
    }
}
