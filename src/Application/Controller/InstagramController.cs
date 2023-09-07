using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Service;
using System.Threading.Tasks;

namespace Application.Controller
{
    public class InstagramController
    {
        private readonly IGraphService _graphService;

        public InstagramController(IGraphService graphService)
        {
            _graphService = graphService;
        }

        [FunctionName("fetch-image")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var graph = await _graphService.GetAllItemsAsync();

            return new OkObjectResult(graph);
        }
    }
}
