using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers;

[ApiController]
[Route("api")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Main()
    {
        return Ok("Hello World!");
    }
}
