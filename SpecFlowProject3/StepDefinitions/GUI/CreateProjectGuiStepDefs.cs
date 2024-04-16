using FinalTask.Core;
using FinalTask.Models;
using FinalTask.Pages;
using FinalTask.Steps;
using NUnit.Framework;
using System.Xml.Linq;


namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class CreateProjectGuiStepDefs : BaseGuiSteps
    {
        public CreateProjectGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            HomePage = new HomePage(Driver);
            ProjectSteps = new ProjectSteps(Driver);
            ProjectPage = new ProjectPage(Driver);
        }

        [When("user click AddProjectButton")]
        public void ClickAddProjectButton()
        {
            HomePage!.AddProjectButtonClick();
            HomePage.IsModalDialogOpen();
        }

        [When("modal dialog is opened")]
        public void ModalFialogOpened()
        {
            Assert.That(HomePage.IsModalDialogOpen());
        }

        [When(@"user enters ""(.*)"" to the projectName field and ""(.*)"" to the projectSummary field")]
        public void FillProjectFields(string name, string summary)
        {
            Project project = new()
            { Name = name, Summary = summary };

            ProjectSteps.CreateProject(project);
        }

        [When(@"user enters ""(.*)"" to the projectName field and summary")]
        public void FillSummaryWithBoundary(string name, string multilineText)
        {
            Project project = new()
            { Name = name, Summary = multilineText };

            ProjectSteps.CreateProject(project);
        }

        [Then("count of chars is equal to 80")]
        public void CheckCountOfChars()
        {
            Assert.That(HomePage!.CountOfCharsBy.Text, Is.EqualTo("80/80"));
        }

        [Then(@"Project is created with name ""(.*)""")]
        public void IsProjectCreated(string name)
        {
            Assert.That(ProjectPage!.IsPageOpened(), Is.EqualTo(true));   
        }
    }
}
