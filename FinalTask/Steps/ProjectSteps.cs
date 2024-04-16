using FinalTask.Models;
using FinalTask.Pages;
using OpenQA.Selenium;


namespace FinalTask.Steps
{
    public class ProjectSteps : BaseSteps
    {
        public ProjectSteps(IWebDriver driver) : base(driver)
        {
        }

        public void CreateProject(Project project)
        {
            HomePage = new HomePage(Driver);
            HomePage.ProjectNameInputBy.SendKeys(project.Name);
            HomePage.ProjectSummaryInputBy.SendKeys(project.Summary);

            HomePage.CreateProjectButtonClick();
        }
    }
}
