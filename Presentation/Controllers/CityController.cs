using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Presentation.Controller;

[ApiController]
[Route("/")]
public class CityController : ControllerBase
{
    private readonly ILogger<CityController> _logger;
    public CityController(ILogger<CityController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Index()
    {
        _logger.LogInformation(">> Load index page");
        return Ok("Hello world!!");
    }
}