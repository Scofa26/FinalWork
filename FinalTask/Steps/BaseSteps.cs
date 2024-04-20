using FinalTask.Pages;
using OpenQA.Selenium;



namespace FinalTask.Steps
{
    public class BaseSteps(IWebDriver driver)
    {
        protected readonly IWebDriver Driver = driver;

        protected LoginPage? LoginPage { get; set; }
        protected HomePage? HomePage { get; set; }
        protected Admin? Admin { get; set; }
        protected ProjectPage? ProjectPage { get; set; }

    }
}
