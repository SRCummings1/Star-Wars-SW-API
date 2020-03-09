using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWAPI.Models;

namespace SW_API.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()

        {
            return View();
        }



    }
}
