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
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallService _magicEightBallService;

        public MagicEightBallController(MagicEightBallService magicEightBallService)
        {
            _magicEightBallService = magicEightBallService;
        }

        [HttpGet]
        [Route("AskAQuestion/{AskHere}")]
        public string GetResponse()
        {
            return _magicEightBallService.GetResponseForQuestion();
        }
    }
}