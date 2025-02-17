using Dapr.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDN.Demo.Messages;

namespace SDN.Demo.Sender.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SenderController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string? name, [FromServices] DaprClient daprClient)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest("Name is required.");
        }

        await daprClient.PublishEventAsync(
            "sdn-pub-sub", 
            "sdn-topic", 
            new Payload(name));

        return Ok($"Name '{name}' sent");
    }

}
