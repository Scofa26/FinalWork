using FinalTask.Models;
using FinalTask.Services;
using NLog;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.API
{
    [Binding]
    public class ApiAutomationRunStepDefs : BaseApiSteps
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        HttpStatusCode statusCode;
        public ApiAutomationRunStepDefs(AutomationRunService AutomationRunService, ScenarioContext scenarioContext) : base(AutomationRunService, scenarioContext)
        {

        }

        [Given(@"called automation run with id ""(.*)""")]
        public void AutomationRunTest(int project_id)
        {
            statusCode = AutomationRunService.AutomationRunTest(project_id).Result.StatusCode;
            _logger.Info(statusCode);
        }

        [Then("status code is 201 Created")]
        public void GetResponse()
        {
            Assert.That(statusCode, Is.EqualTo(HttpStatusCode.Created));
        }
    }
}
