using FinalTask.Clients;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Services
{
    public class AutomationRunService : IAutomationRunService
    {
        private readonly RestClientExtended _client;

        public AutomationRunService(RestClientExtended client)
        {
            _client = client;
        }

        public Task<RestResponse> AutomationRunTest(int projectId)
        {
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePathForBody = Path.Combine(assemblyPath, "Resources", "BodyForAutomationRun.json");
            string filePathForToken = Path.Combine(assemblyPath, "Resources", "token.txt");
            string body = File.ReadAllText(filePathForBody);
            string token = File.ReadAllText(filePathForToken);

            var request = new RestRequest("/api/v1/projects/{project_id}", Method.Post)
             .AddUrlSegment("project_id", projectId + "/automation/runs")
             .AddHeader("Authorization", token)
             .AddJsonBody(body);

            return _client.ExecuteAsync(request);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
