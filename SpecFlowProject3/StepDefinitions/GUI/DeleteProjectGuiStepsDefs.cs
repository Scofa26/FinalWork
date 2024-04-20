using FinalTask.Core;
using FinalTask.Elements;
using FinalTask.Pages;
using FinalTask.Steps;
using NLog;
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
    public class DeleteProjectGuiStepsDefs : BaseGuiSteps
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public DeleteProjectGuiStepsDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            HomePage = new HomePage(Driver);
            AdminPanel = new Admin(Driver);
            AdminPanelProjects = new AdminProjects(Driver);
            NavigationSteps = new NavigationSteps(Driver);
        }

        [Given(@"user clicks Admin button on HomePage")]
        public void GivenUserClicksAdminButtonOnHomePage()
        {
            NavigationSteps.GoToAdminPanel();
        }

        [Given("user clicks Projects section")]
        public void GoToProhectsSection()
        {
            NavigationSteps.GoToAdminPanelProjects();
        }

        [When("user clicks delete item")]
        public void ClickDeleteIcon()
        {
            TableCell tableCell = AdminPanelProjects!.ProjectsTable.GetCell("Project", "FirstProject", 3);
            _logger.Info(tableCell.ToString());

            tableCell.DeleteAction().Click();
        }

        [When("delete modal dialog is opened")]
        public void ModalDialogIsOpened()
        {
            Assert.That(AdminPanelProjects!.DeleteDialogWindowBy.Text, Is.EqualTo("Delete project"));
        }

        [When("user confirms agreement checkbox")]
        public void ConfirmSelectingCheckBox()
        {
            AdminPanelProjects!.CheckBoxDeleteBy.Click();
        }

        [When("user clicks Delete project button")]
        public void ClickDeleteButton()
        {
            AdminPanelProjects!.DeleteButtonBy.Click();
        }


        [Then("Project successfully deleted")]
        public void IsProjectDeleted()
        {
            Assert.That(AdminPanelProjects!.DeleteIconBy.Displayed);
        }
    }
}
