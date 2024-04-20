using Allure.SpecFlowPlugin;
using FinalTask.Core;
using FinalTask.Helpers;
using FinalTask.Models;
using FinalTask.Pages;
using FinalTask.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.GUI
{
    [Binding]
    public class UploadFileGuiStepsDefs : BaseGuiSteps
    {
        public UploadFileGuiStepsDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
        {
            RepositoryPage = new RepositoryPage(Driver);
            NavigationSteps = new NavigationSteps(Driver);
        }

        [Given("Repository page is opened")]
        public void OpenRepositoryPage()
        {
            NavigationSteps.GoToRepositoryPage();
        }

        [When("user clicks on add testcase button")]
        public void ClickAddTestCaseButton()
        {
            RepositoryPage!.AddTestCaseButtonBy.Click();
        }

        [When("user chooses file to upoad")]
        public void ChooseFileToUpload()
        {
            var fileUploadElement = RepositoryPage!.FileUploadElementBy;
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyPath, "Resources", "upload.txt");
            fileUploadElement.SendKeys(filePath);
        }

        [Then("file is successfule uploaded and file name is displayed on add test case modal window")]
        public void IsFileUploaded()
        {
            Assert.That(RepositoryPage!.FileUploadElementNameBy.Text, Is.EqualTo("upload.txt"));
        }
    }
}
