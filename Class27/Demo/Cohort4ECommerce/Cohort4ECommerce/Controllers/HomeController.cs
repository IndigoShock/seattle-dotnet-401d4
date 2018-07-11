﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cohort4ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cohort4ECommerce.Controllers
{
    public class HomeController : Controller
    {
		private ICMSRepo _repo;

		public HomeController(ICMSRepo repo)
		{
			_repo = repo;
		}
        public IActionResult Index()
        {
			
            return View();
        }
    }
}