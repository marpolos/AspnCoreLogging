using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AspCoreLogging.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    ILogger _logger;
    public ValuesController(ILogger<ValuesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        _logger.LogInformation("Executando api/values -> Get");
        return new string[] { "valor1", "valor2" };
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        _logger.LogInformation("Executando api/values/id -> Get(id)" + id.ToString());
        return "valor de id igual a " + id;
    }
}