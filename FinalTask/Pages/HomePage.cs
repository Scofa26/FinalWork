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
        private static readonly By CountOfChars = By.CssSelector("[class='maxlength-counter__counter']");
        private static readonly By NavbarUserIconLink = By.CssSelector("[class='navbar__user__icon__link']");
        private static readonly By AlertHeader = By.CssSelector("[class='popup__menu__header']");
        private static readonly By AdminLink = By.CssSelector("body > div.navbar > div.navbar__menu > ul:nth-child(2) > li > a");
        private static readonly By ProjectNameTitleLink = By.XPath("//div[@class='card__header__title']/a");
        private static readonly By ProjectSummaryText = By.CssSelector("[data-target='note behavior--maxlength-counter.control']");

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
        public IWebElement CountOfCharsBy => WaitHelpers.WaitForExists(CountOfChars);
        public IWebElement NavbarUserIconLinkBy => WaitHelpers.WaitForExists(NavbarUserIconLink);
        public IWebElement AlertHeaderBy => WaitHelpers.WaitForExists(AlertHeader);
        public IWebElement AdminLinkBy => WaitHelpers.WaitForExists(AdminLink);
        public IWebElement ProjectNameTitleLinkBy => WaitHelpers.WaitForExists(ProjectNameTitleLink);
        public IWebElement ProjectSummaryTextBy => WaitHelpers.WaitForExists(ProjectSummaryText);

        public void AddProjectButtonClick() => AddProjectButtonBy.Click();
        public void CreateProjectButtonClick() => CreateProjectButtonBy.Click();

      
        public override bool IsPageOpened()
        {
            return ProjectTitleBy.Displayed;
        }

        public bool IsModalDialogOpen()
        {
            return ModalDialogTitleBy.Text.Trim().Equals("Add project");
        }

        public bool IsAlertOpen()
        {
            return AlertHeaderBy.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
