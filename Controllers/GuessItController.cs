using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTenEndPoints.services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenEndPoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;
        public GuessItController(GuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("Play/{mode}/{guess}")]
        public string PlayGame(string mode, string guess)
        {
            return _guessItService.HandleGame(mode, guess);
        }
    }
}