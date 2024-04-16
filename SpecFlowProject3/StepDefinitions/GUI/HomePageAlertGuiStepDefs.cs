using FinalTask.Core;
using FinalTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class HomePageAlertGuiStepDefs : BaseGuiSteps
    {
        public HomePageAlertGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            HomePage = new HomePage(Driver);
        }

        [When("user hovers navbaricon")]
        public void HoverNavbarIcon()
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(HomePage!.NavbarUserIconLinkBy)
                .Build()
                .Perform();
        }

        [Then("alert is opened")]
        public void IsAlertWindowOpen()
        {
            Assert.That(HomePage!.IsAlertOpen(), Is.EqualTo(true));
        }

        [Then(@"alerts Title is equal to ""(.*)""")]
        public void ValidateAlertTitleText(string title)
        {
            Assert.That(HomePage!.AlertHeaderBy.Text, Is.EqualTo(title.ToUpper()));
        }
    }
}
