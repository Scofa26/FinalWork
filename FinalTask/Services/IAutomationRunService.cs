using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Services
{
    public interface IAutomationRunService
    {
        Task<RestResponse> AutomationRunTest(int projectId);
    }
}
