using AQA_Finals.Core;
using AQA_Finals.Helpers.Configuration;
using AQA_Finals.Models;
using AQA_Finals.Pages;
using AQA_Finals.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.GUI
{
    public class BaseGuiSteps
    {
        protected IWebDriver Driver { get; }
        protected ScenarioContext ScenarioContext { get; }
        protected LoginPage? LoginPage { get; set; }
        protected NavigationSteps NavigationSteps { get; set; } 
        protected User Admin { get; set; }

        public BaseGuiSteps(Browser browser, ScenarioContext scenarioContext)
        {
            Driver = browser.Driver;
            ScenarioContext = scenarioContext;

            Admin = new User

            {
                Email = Configurator.AppSettings.Username,
                Password = Configurator.AppSettings.Password
            };
        }
    }
}
