﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {

        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        public string Index()
        {
            return "Hello world";
        }

    }
}
