﻿using IHunger.Domain.Interfaces;
using IHunger.Domain.Interfaces.Services;
using IHunger.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHunger.WebAPI.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class RestaurantController : MainController
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(
            IRestaurantService restaurantService,
            INotifier notifier, 
            IUser appUser) : base(notifier, appUser)
        {
            _restaurantService = restaurantService;
        }
    }
}
