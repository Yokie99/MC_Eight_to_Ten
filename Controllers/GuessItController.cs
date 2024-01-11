using MC_Eight_to_Ten.Sercives.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace MC_Eight_to_Ten.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }


    [HttpGet]
    [Route("Easy/{input}")]
    public string easy(string input)
    {
        return _guessItService.easy(input);
    }



    [HttpGet]
    [Route("Medium/{input}")]
    public string medium(string input)
    {
        return _guessItService.medium(input);
    }


    [HttpGet]
    [Route("Hard/{input}")]
    public string hard(string input)
    {
        return _guessItService.hard(input);
    }
}
