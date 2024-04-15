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

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        IWebElement ProjectTitleBy => WaitHelpers.WaitForExists(ProjectTitle);
        IWebElement AddProjectButtonBy => WaitHelpers.WaitForExists(AddProjectButton);

        public void AddProjectButtonClick() => AddProjectButtonBy.Click();

        public override bool IsPageOpened()
        {
            return ProjectTitleBy.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
