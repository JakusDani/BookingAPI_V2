using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller;

[ApiController]
[Route("/")]
public class CityController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello world!!!");
    }
}