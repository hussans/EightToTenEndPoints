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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("PickItalianChineseOrMexican/{category}")]
        public string PickRestaurant(string category)
        {
            return _restaurantPickerService.GetRandomRestaurant(category);
        }
    }
}