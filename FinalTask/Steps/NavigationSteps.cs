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

        public ProjectPage GoToProjectPage()
        {
            HomePage = new HomePage(Driver);
            HomePage.ProjectNameTitleLinkBy.Click();
            return new ProjectPage(Driver);
        }

        public RepositoryPage GoToRepositoryPage()
        {
            HomePage = new HomePage(Driver);
            HomePage.ProjectNameTitleLinkBy.Click();
            ProjectPage = new ProjectPage(Driver);
            ProjectPage.PepositoryLinkBy.Click();
            return new RepositoryPage(Driver);
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

        public Admin GoToAdminPanel()
        {
            return AdminPanel<Admin>();
        }

        public AdminProjects GoToAdminPanelProjects()
        {
            return AdminPanelProjects<AdminProjects>();
        }

        public T Login<T>(User user) where T : BasePage
        {
            LoginPage = new LoginPage(Driver);
            LoginPage.EmailInput.SendKeys(user.Email);
            LoginPage.PasswordInput.SendKeys(user.Password);
            LoginPage.ClickLoginButton();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }

        public T AdminPanel<T>() where T : BasePage
        {  
            HomePage = new HomePage(Driver);
            HomePage.AdminLinkBy.Click();
            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }

        public T AdminPanelProjects<T>() where T : BasePage
        {
            Admin = new Admin(Driver);
            Admin.ProjectsLinkBy.Click();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
