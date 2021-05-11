using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodDeliveryApi.Models;

namespace FoodDeliveryApi.Controllers
{
    public class FoodDeliveryController : Controller
    {
        private FoodDeliveryServices service;

        public FoodDeliveryController(FoodDeliveryServices service)
        {
            this.service = service;
        }

        [HttpPost("restaurants")]
        public ActionResult<Restaurant> PostRestaurant(Restaurant model)
        {
            return null;
        }
        
    }
}

