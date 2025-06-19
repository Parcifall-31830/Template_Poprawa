using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller(IDbService Service):ControllerBase
{
    // [HttpGet]
    // public IActionResult Get()
    // {
    //     // return Ok(await Service);
    // }
}