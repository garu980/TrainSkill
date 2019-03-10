using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;
using TrainSkill.CrossCuttingConcerns;
using TrainSkill.Functions;

namespace TrainSkill
{
    public static class TrainSearch
    {
        public static IFunctionFactory Factory = new FunctionFactory(new CompositionRoot());

        [FunctionName("WhereIsMyTrain")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            var function = Factory.Create<ITrainFunction>();
            var response = await function.InvokeAsync(req).ConfigureAwait(false);
            return new OkObjectResult(response);
        }
    }
}
