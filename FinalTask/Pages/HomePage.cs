using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class HomePage : BasePage
    {
        private static string END_POINT = "";
        private static readonly By ProjectTitle = By.ClassName("page-title__title");
        private static readonly By AddProjectButton = By.CssSelector("[class='ui basic compact button']");
        private static readonly By ProjectNameInput = By.CssSelector("[placeholder='Project name']");
        private static readonly By ProjectSummaryInput = By.TagName("textarea");
        private static readonly By CreateProjectButton = By.CssSelector("[class='ui button primary']");
        private static readonly By ModalDialogTitle = By.CssSelector("[class='dialog__header__content__title']");

        private List<IWebElement> _projectNames;
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage(IWebDriver driver, bool openByUrl) : base(driver)
        {
        }
        public IWebElement ProjectTitleBy => WaitHelpers.WaitForExists(ProjectTitle);
        public IWebElement AddProjectButtonBy => WaitHelpers.WaitForExists(AddProjectButton);
        public IWebElement ProjectNameInputBy => WaitHelpers.WaitForExists(ProjectNameInput);
        public IWebElement ProjectSummaryInputBy => WaitHelpers.WaitForExists(ProjectSummaryInput);
        public IWebElement CreateProjectButtonBy => WaitHelpers.WaitForExists(CreateProjectButton);
        public IWebElement ModalDialogTitleBy => WaitHelpers.WaitForExists(ModalDialogTitle);

        public void AddProjectButtonClick() => AddProjectButtonBy.Click();
        public void CreateProjectButtonClick() => CreateProjectButtonBy.Click();

        public bool FindAllProjects(string name)
        {
            IReadOnlyList <IWebElement> _projectNames = Driver.FindElements(By.TagName("a"));
            bool res = false;
            foreach (var pr in _projectNames)
                if (pr.Text == name) res = true;

            return res;
        }
        public override bool IsPageOpened()
        {
            return ProjectTitleBy.Displayed;
        }

        public bool IsModalDialogOpen()
        {
            return ModalDialogTitleBy.Text.Trim().Equals("Add project");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
