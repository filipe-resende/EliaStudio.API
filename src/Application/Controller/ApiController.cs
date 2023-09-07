using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Service;
using System.IO;
using System.Threading.Tasks;

namespace Application.Controller
{
    public class APIController
    {
        private readonly IGraphService _graphService;
        private readonly IEmailSenderService _emailSenderService;
        public APIController(IGraphService graphService, IEmailSenderService emailSenderService)
        {
            _graphService = graphService;
            _emailSenderService = emailSenderService;
        }

        [FunctionName("fetch-image")]
        public async Task<IActionResult> FetchImage(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var graph = await _graphService.GetAllItemsAsync();

            return new OkObjectResult(graph);
        }

        [FunctionName("send-email")]
        public async Task<IActionResult> SendEmail (
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var clientInfo = JsonConvert.DeserializeObject<ClientInfo>(requestBody);

            _emailSenderService.EmailSender(clientInfo);

            return new OkObjectResult("Email enviado!");
        }
    }
}
