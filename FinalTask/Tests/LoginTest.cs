using Allure.Net.Commons;
using FinalTask.Models;
using FinalTask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace FinalTask.Tests
{

    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            LoginPage _loginPage = new LoginPage(Driver);
            _loginPage.EmailInput.SendKeys(Admin.Email);
            _loginPage.PasswordInput.SendKeys(Admin.Password);
            _loginPage.ClickLoginButton();

            HomePage _homepage = new HomePage(Driver);

            _homepage.AddProjectButtonClick();

         
            Thread.Sleep(5000);
        }


    }
}
