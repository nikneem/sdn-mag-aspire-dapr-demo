using Dapr;
using Microsoft.AspNetCore.Mvc;
using SDN.Demo.Messages;

namespace SDN.Demo.Receiver.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReceiverController : ControllerBase
{

    [HttpPost]
    [Topic("sdn-pub-sub", "sdn-topic")]
    public IActionResult Post([FromBody] Payload payload)
    {
        Console.WriteLine($"Just received a message from {payload.Name}");
        return Ok();
    }
}