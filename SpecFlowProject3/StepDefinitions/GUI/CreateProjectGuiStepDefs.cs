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
        }

        [When("user click AddProjectButton")]
        public void ClickAddProjectButton()
        {
            HomePage.AddProjectButtonClick();
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

        [Then(@"Project is created with name ""(.*)""")]
        public void IsProjectCreated(string name)
        {
            Assert.That(HomePage.FindAllProjects(name), Is.EqualTo(true));
        }
    }
}
