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
        private static string END_POINT = "";

        private static readonly By ProjectsLink = By.LinkText("https://mtswork.testmo.net/admin/projects");
        private static readonly By DeleteProjectButton = By.XPath("//tr[@data-name='projectName2']/child::*");

        public Admin(IWebDriver driver) : base(driver)
        {
        }
        public Admin(IWebDriver driver, bool openByUrl) : base(driver)
        {
        }

        public IWebElement ProjectsLinkBy => WaitHelpers.WaitForExists(ProjectsLink);
        public IWebElement DeleteProjectButtonBy => WaitHelpers.WaitForExists(DeleteProjectButton);


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
