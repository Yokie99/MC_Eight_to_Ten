using MC_Eight_to_Ten.Sercives.EightBall;
using Microsoft.AspNetCore.Mvc;

namespace MC_Eight_to_Ten.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService)
    {
        _eightBallService = eightBallService;
    }

    [HttpGet]
    [Route("AskTheBall")]

    public string magic(){
        return _eightBallService.magic();
    }
}
