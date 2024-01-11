using MC_Eight_to_Ten.Sercives.Resturant;
using Microsoft.AspNetCore.Mvc;

namespace MC_Eight_to_Ten.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ResturantController : ControllerBase
    {
    private readonly IResturantService _resturantService;

    public ResturantController(IResturantService resturantService)
        {
        _resturantService = resturantService;
    }
        [HttpGet]
        [Route("Hunger/{input}")]

        public string WhatToEat(string input)
        {
            return _resturantService.WhatToEat(input);
        }
    }
