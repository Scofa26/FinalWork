using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class ProjectPage : BasePage
    {
        private static string END_POINT = "";
        private static readonly By ProjectName = By.CssSelector("[class='page-header__title']");

        public ProjectPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ProjectNameBy => WaitHelpers.WaitForExists(ProjectName);

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return ProjectNameBy.Displayed;
        }
    }
}
