using Microsoft.AspNetCore.Mvc;

namespace GymHero.API.Controllers;

[ApiController]
[Route("workout")]
public class WorkoutController : ControllerBase
{
    [HttpGet("/ping")]
    public string Ping()
    {
        return DateTimeOffset.Now.ToString();
    }
    
}