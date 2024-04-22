﻿using FinalTask.Clients;
using FinalTask.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions.API
{
    public class BaseApiSteps
    {
        protected ScenarioContext ScenarioContext { get; }
        protected ProjectService ProjectService;

        public BaseApiSteps(ProjectService ProjectService,ScenarioContext scenarioContext)
        {
            ScenarioContext = scenarioContext;
            this.ProjectService = ProjectService;
        }


    }
}
