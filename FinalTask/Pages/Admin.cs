using FinalTask.Elements;
using NUnit.Framework;
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
        private static string END_POINT = "/admin";

        private static readonly By ProjectsLink = By.CssSelector("[class='admin-home-links__link__title']");
        private static readonly By PageTitle = By.CssSelector("[class='page-header__title']");
      
        public Admin(IWebDriver driver) : base(driver)
        {

        }
        public Admin(IWebDriver driver, bool openByUrl) : base(driver)
        {

        }

        public IWebElement ProjectsLinkBy => WaitHelpers.WaitForExists(ProjectsLink);
        public IWebElement PageTitleBy => WaitHelpers.WaitForExists(PageTitle);

        public override bool IsPageOpened()
        {
            return PageTitleBy.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
