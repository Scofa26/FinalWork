using FinalTask.Models;
using FinalTask.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Steps
{
    public class NavigationSteps : BaseSteps
    {
        public NavigationSteps(IWebDriver driver) : base(driver)
        {
        }
        public LoginPage NavigateToLoginPage()
        {
            return new LoginPage(Driver);
        }
        public HomePage SuccessfulLogin(User user)
        {
            return Login<HomePage>(user);
        }

        public LoginPage IncorrectLogin(User user)
        {
            return Login<LoginPage>(user);
        }

        public T Login<T>(User user) where T : BasePage
        {
            LoginPage = new LoginPage(Driver);
            LoginPage.EmailInput.SendKeys(user.Email);
            LoginPage.PasswordInput.SendKeys(user.Password);
            LoginPage.ClickLoginButton();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }

    }
}
