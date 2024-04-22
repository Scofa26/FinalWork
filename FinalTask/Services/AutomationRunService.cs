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
            string filePath = Path.Combine(assemblyPath, "Resources", "BodyForAutomationRun.json");
            string text = File.ReadAllText(filePath);

            var request = new RestRequest("/api/v1/projects/{project_id}", Method.Post)
             .AddUrlSegment("project_id", projectId + "/automation/runs")
             .AddHeader("Authorization", "Bearer testmo_api_eyJpdiI6Ilo1eE1QNUxwbG12NU5DMzg1RC9nWlE9PSIsInZhbHVlIjoiTnNUWHh3VTlIZDJ4VjdMQjdnTnVCSWNmdlA5bHpSTG1wdUY3RlpHc2EwTT0iLCJtYWMiOiI1YmQ1ZWNmNjVmYmU2NTRlNTgxODA5YTE4NzhiNzgzNTIzOWZiZjRkNTI1NTJjMTI4YzRmNmY3ZmMzNGY3NGQwIiwidGFnIjoiIn0=")
             .AddJsonBody(text);

            return _client.ExecuteAsync(request);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
