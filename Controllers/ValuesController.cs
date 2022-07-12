using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    private readonly ILogger<ValuesController> _logger;

    public ValuesController(ILogger<ValuesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<string> Get()
    {   
        var texto = new string[] {"value1", "value2"};
        return texto.ToList();
    }
}
