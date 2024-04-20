using FinalTask.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class Admin : BasePage
    {
        private static string END_POINT = "/admin/projects";

        private static readonly By ProjectsLink = By.CssSelector("[class='admin-home-links__link__title']");
        private static readonly By DeleteProjectButton = By.XPath("//tr[@data-name='projectName2']/child::*");
        private static readonly By ProjectsTableBy = By.XPath("/html/body/div[2]/div[2]/div[2]/div/div[1]/div[3]/div[2]/div/table");
        public Admin(IWebDriver driver) : base(driver)
        {
        }
        public Admin(IWebDriver driver, bool openByUrl) : base(driver)
        {
        }

        public IWebElement ProjectsLinkBy => WaitHelpers.WaitForExists(ProjectsLink);
        public IWebElement DeleteProjectButtonBy => WaitHelpers.WaitForExists(DeleteProjectButton);
        public Table ProjectsTable => new(Driver, ProjectsTableBy);


        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
