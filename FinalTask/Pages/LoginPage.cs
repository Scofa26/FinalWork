using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By Email = By.Name("email");
        private static readonly By Password = By.Name("password");
        private static readonly By LoginButton = By.CssSelector("button[class ='ui primary button']");
        private static readonly By ErrorLabel = By.CssSelector("[class ='message-block message-block--negative message-block--scroll']");

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        public LoginPage(IWebDriver driver, bool openByUrl) : base(driver)
        {

        }
        public IWebElement EmailInput => WaitHelpers.WaitForExists(Email);
        public IWebElement PasswordInput => WaitHelpers.WaitForExists(Password);
        public IWebElement LoginButtonClick => WaitHelpers.WaitForExists(LoginButton);
        public IWebElement ErrorLabelBy => WaitHelpers.WaitForExists(ErrorLabel);

        public void ClickLoginButton() => LoginButtonClick.Click();

        public override bool IsPageOpened()
        {
            return LoginButtonClick.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
