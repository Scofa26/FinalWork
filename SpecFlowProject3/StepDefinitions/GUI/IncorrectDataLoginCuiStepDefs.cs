using FinalTask.Core;
using FinalTask.Pages;
using FinalTask.Steps;
using NLog;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class IncorrectDataLoginCuiStepDefs : BaseGuiSteps
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public IncorrectDataLoginCuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            NavigationSteps = new NavigationSteps(Driver);
            LoginPage = new LoginPage(Driver);
        }

        [Given("open the login page and enter wrong pass and wrong email")]
        public void LoginWithIncorrectDate()
        {
            NavigationSteps.IncorrectLogin(WrongUser);
        }

        [Then("Get error message")]
        public void GetErrorMessage()
        {
            _logger.Error(LoginPage!.ErrorLabelBy.Text.Trim());
            Assert.That(LoginPage!.ErrorLabelBy.Text.Trim(), Is.EqualTo("These credentials do not match our records or the user account is not allowed to log in."));
        }
    }
}
