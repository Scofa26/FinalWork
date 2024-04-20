using FinalTask.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class AdminProjects : BasePage
    {
        private static string END_POINT = "/admin/projects";

        private static readonly By PageTitle = By.CssSelector("[class='page-header__title']");
        private static readonly By ProjectsTableBy = By.CssSelector("[data-target='components--table.table']");
        private static readonly By DeleteDialogWindow = By.ClassName("dialog__header__content__title");
        private static readonly By CheckBoxDelete = By.CssSelector("[data-target='confirmationLabel']");
        private static readonly By DeleteButton = By.CssSelector("[class='ui negative button']");
        private static readonly By DeleteIcon = By.CssSelector("[class='fas fa-ban icon-deleted-entity']");

        public AdminProjects(IWebDriver driver) : base(driver)
        {
        }
        public AdminProjects(IWebDriver driver, bool openByUrl) : base(driver)
        {
        }

        public IWebElement DeleteDialogWindowBy => WaitHelpers.WaitForExists(DeleteDialogWindow);
        public IWebElement CheckBoxDeleteBy => WaitHelpers.WaitForExists(CheckBoxDelete);
        public IWebElement DeleteButtonBy => WaitHelpers.WaitForExists(DeleteButton);
        public IWebElement DeleteIconBy => WaitHelpers.WaitForExists(DeleteIcon);
        public IWebElement PageTitleBy => WaitHelpers.WaitForExists(PageTitle);


        public Table ProjectsTable => new(Driver, ProjectsTableBy);

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
