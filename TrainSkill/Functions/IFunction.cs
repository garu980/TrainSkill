using Alexa.NET.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;

namespace TrainSkill.Functions
{
    public interface IFunction
    {
        Task<SkillResponse> InvokeAsync(HttpRequest req);
    }
}
