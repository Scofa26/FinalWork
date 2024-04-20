using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class RepositoryPage : BasePage
    {
        private static string END_POINT = "/repositories/{id}";
        private static readonly By RepositoryTitle = By.CssSelector("[class='page-header__title']");
        private static readonly By AddTestCaseButton = By.CssSelector("[data-target='repositories--index.nodataAddCaseButton']");
        private static readonly By FileUploadElement = By.CssSelector("[data-target='attachments--dialog-manage.fileInput']");
        private static readonly By FileUploadElementName = By.XPath("//div[@class='attachments-dialog-split-list__item__title__content']/a");

        public RepositoryPage(IWebDriver driver) : base(driver)
        {
        }
        public RepositoryPage(IWebDriver driver, bool openByUrl) : base(driver)
        {
        }

        public IWebElement RepositoryTitleBy => WaitHelpers.WaitForExists(RepositoryTitle);
        public IWebElement AddTestCaseButtonBy => WaitHelpers.WaitForExists(AddTestCaseButton);
        public IWebElement FileUploadElementBy => WaitHelpers.WaitForExists(FileUploadElement);
        public IWebElement FileUploadElementNameBy => WaitHelpers.WaitForExists(FileUploadElementName);

        public override bool IsPageOpened()
        {
            return RepositoryTitleBy.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
