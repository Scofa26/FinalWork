using FinalTask.Models;
using FinalTask.Services;
using FinalTask.Steps;
using NLog;
using NUnit.Framework;
using SpecFlow.Internal.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.API
{
    [Binding]
    public class GetProjectApiStepDefs : BaseApiSteps
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        ResultProject _project;
        string content = "";
        HttpStatusCode codeForTestWithWrongId;
        HttpStatusCode codeWithoutAuth;

        public GetProjectApiStepDefs(ProjectService ProjectService, ScenarioContext scenarioContext) : base(ProjectService, scenarioContext)
        {
        }

        [Given(@"called get project service with id ""(.*)""")]
        public void GetProjectTest(int project_id)
        {
            _project = ProjectService?.GetProject(project_id).Result;

            _logger.Info(_project.ToString());
        }

        [Given(@"called get project service with non-existetnt id ""(.*)""")]
        public void GetProjectTestWithWrongId(int project_id)
        {
            var _result = ProjectService?.GetProjectContent(project_id);
            content = _result.Result.Content;
            codeForTestWithWrongId = _result.Result.StatusCode;
            _logger.Info(content);
            _logger.Info(codeForTestWithWrongId);
        }

        [Given(@"called get project service with id ""(.*)"" without auth")]
        public void GetProjectTestWithoutAuth(int project_id)
        {
            codeWithoutAuth = ProjectService.GetProjectContentWithNoAuth(project_id);

            _logger.Info(codeWithoutAuth);
        }

        [Then("project is successfully got")]
        public void IsProjectGot()
        {
            Assert.That(_project.Projects.Name, Is.EqualTo("projectName2"));
        }

        [Then(@"get the error message ""(.*)""")]
        public void IsProjectGotWithNonExistetntId(string errorMessage)
        {
            Assert.That(content, Is.EqualTo(errorMessage));
        }

        [Then(@"status code ""(.*)""")]
        public void CheckStatusCodeForTestWithNoId(HttpStatusCode code)
        {
            Assert.That(codeForTestWithWrongId, Is.EqualTo(code));
        }

        [Then(@"status code is ""(.*)""")]
        public void CheckStatusCodeForTestWithNoAuth(HttpStatusCode code)
        {
            Assert.That(codeWithoutAuth, Is.EqualTo(code));
        }
    }
}
