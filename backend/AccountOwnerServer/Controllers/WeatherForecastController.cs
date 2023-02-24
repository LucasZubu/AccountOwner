using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Testando o log de informação");
        _logger.LogDebug("Testando o log debug");
        _logger.LogInfo("Testando o log aviso");
        _logger.LogError("Testando o log Erro");
        return new string[] { "valor1" , "valor2" };
    }
}
