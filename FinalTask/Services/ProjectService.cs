using FinalTask.Clients;
using FinalTask.Models;
using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Services
{
    public class ProjectService : IProjectService
    {
        private readonly RestClientExtended _client;

        public ProjectService(RestClientExtended client)
        {
            _client = client;
        }

        public Task<ResultProject> GetProject(int projectId)
        {
            var request = new RestRequest("/api/v1/projects/{project_id}")
              .AddUrlSegment("project_id", projectId)
              .AddHeader("Authorization", "Bearer testmo_api_eyJpdiI6Ilo1eE1QNUxwbG12NU5DMzg1RC9nWlE9PSIsInZhbHVlIjoiTnNUWHh3VTlIZDJ4VjdMQjdnTnVCSWNmdlA5bHpSTG1wdUY3RlpHc2EwTT0iLCJtYWMiOiI1YmQ1ZWNmNjVmYmU2NTRlNTgxODA5YTE4NzhiNzgzNTIzOWZiZjRkNTI1NTJjMTI4YzRmNmY3ZmMzNGY3NGQwIiwidGFnIjoiIn0=");

            return _client.ExecuteAsync<ResultProject>(request);
        }
        
        public Task<RestResponse> GetProjectContent(int projectId)
        {
            var request = new RestRequest("/api/v1/projects/{project_id}")
              .AddUrlSegment("project_id", projectId)
              .AddHeader("Authorization", "Bearer testmo_api_eyJpdiI6Ilo1eE1QNUxwbG12NU5DMzg1RC9nWlE9PSIsInZhbHVlIjoiTnNUWHh3VTlIZDJ4VjdMQjdnTnVCSWNmdlA5bHpSTG1wdUY3RlpHc2EwTT0iLCJtYWMiOiI1YmQ1ZWNmNjVmYmU2NTRlNTgxODA5YTE4NzhiNzgzNTIzOWZiZjRkNTI1NTJjMTI4YzRmNmY3ZmMzNGY3NGQwIiwidGFnIjoiIn0=");

            return _client.ExecuteAsync(request);
        }
    
        public HttpStatusCode GetProjectContentWithNoAuth(int projectId)
        {
            var request = new RestRequest("/api/v1/projects/{project_id}")
             .AddUrlSegment("project_id", projectId);

            return _client.ExecuteAsync(request).Result.StatusCode;
        }
        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
