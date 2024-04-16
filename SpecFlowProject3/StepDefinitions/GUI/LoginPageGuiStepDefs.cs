using FinalTask.Core;
using FinalTask.Models;
using FinalTask.Pages;
using FinalTask.Steps;


namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class LoginPageGuiStepDefs : BaseGuiSteps
    {

        public LoginPageGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            LoginPage = new LoginPage(Driver);
            NavigationSteps = new NavigationSteps(Driver);
        }

        [Given("open the login page and enter pass and email")]
        public void NavigateToLoginPage()
        {
            NavigationSteps.SuccessfulLogin(Admin);
        }
    }
}
