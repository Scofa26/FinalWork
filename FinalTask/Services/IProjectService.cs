using FinalTask.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Services
{
    public interface IProjectService
    {
        Task<ResultProject> GetProject(int projectId);
        Task<RestResponse> GetProjectContent(int projectId);
        HttpStatusCode GetProjectContentWithNoAuth(int projectId);
    }
}
