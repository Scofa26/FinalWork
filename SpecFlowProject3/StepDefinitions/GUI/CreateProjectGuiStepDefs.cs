using FinalTask.Core;
using FinalTask.Models;
using FinalTask.Pages;
using FinalTask.Steps;
using NLog;
using NUnit.Framework;
using System.Xml.Linq;


namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class CreateProjectGuiStepDefs : BaseGuiSteps
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public CreateProjectGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            HomePage = new HomePage(Driver);
            ProjectSteps = new ProjectSteps(Driver);
            ProjectPage = new ProjectPage(Driver);
        }

        [When("user click AddProjectButton")]
        public void ClickAddProjectButton()
        {
            ProjectSteps.ClickAddProjectButton();
        }

        [When("modal dialog is opened")]
        public void ModalFialogOpened()
        {
            Assert.Multiple(() =>
            {
                Assert.That(HomePage!.IsModalDialogOpen());
                Assert.That(HomePage!.ModalDialogTitleBy.Text, Is.EqualTo("Add project"));
            });
        }

        [When(@"user enters ""(.*)"" to the projectName field and ""(.*)"" to the projectSummary field")]
        public void FillProjectFields(string name, string summary)
        {
            Project project = new()
            { Name = name, Summary = summary };
            _logger.Debug($" project {project.ToString()}" );

            ProjectSteps.CreateProject(project);
        }

        [When(@"user enters ""(.*)"" to the projectName field and summary")]
        public void FillSummaryWithBoundary(string name, string multilineText)
        {
            Project project = new()
            { Name = name, Summary = multilineText };

            _logger.Info(project.ToString());

            ProjectSteps.CreateProject(project);
        }

        [When(@"user enters summary is more than 80")]
        public void FillSummaryWithCharsMore80(string multilineText)
        {
            Project project = new()
            { Name = "Test", Summary = multilineText };
            _logger.Info(project.ToString());

            HomePage!.ProjectSummaryInputBy.SendKeys(project.Summary);
        }

        [Then("count of chars is equal to 80")]
        public void CheckCountOfChars()
        {
            Assert.That(HomePage!.CountOfCharsBy.Text, Is.EqualTo("80/80"));
        }

        [Then("Project is created, homePage is opened")]
        public void IsProjectCreated()
        {
            Assert.That(ProjectPage!.IsPageOpened(), Is.EqualTo(true));
        }
    }
}
