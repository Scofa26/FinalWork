using FinalTask.Core;
using FinalTask.Helpers.Configuration;
using FinalTask.Models;
using FinalTask.Pages;
using FinalTask.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProject3.StepDefinitions.GUI
{
    public class BaseGuiSteps
    {
        protected IWebDriver Driver { get; }
        protected ScenarioContext ScenarioContext { get; }
        protected LoginPage? LoginPage { get; set; }
        protected HomePage? HomePage { get; set; }
        protected ProjectPage? ProjectPage { get; set; }
        protected NavigationSteps NavigationSteps { get; set; } 
        protected ProjectSteps ProjectSteps { get; set; } 
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
