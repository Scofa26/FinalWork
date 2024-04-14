using AQA_Finals.Core;
using AQA_Finals.Models;
using AQA_Finals.Pages;
using AQA_Finals.Steps;


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

        [Given("open the login page")]
        public void NavigateToLoginPage()
        {
            NavigationSteps.SuccessfulLogin(Admin);
        }
    }
}
