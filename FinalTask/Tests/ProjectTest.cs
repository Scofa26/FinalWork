using FinalTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Tests
{
    public class ProjectTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            LoginPage _loginPage = new LoginPage(Driver);
            _loginPage.EmailInput.SendKeys(Admin.Email);
            _loginPage.PasswordInput.SendKeys(Admin.Password);
            _loginPage.ClickLoginButton();

            HomePage _homepage = new HomePage(Driver);
            _homepage.FindAllProjects("projectName");


        }
    }
}
