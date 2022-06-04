using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreMvc_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // this action returns the \Views\Home\Index.cshtml page
        {
            return View();
        }

        public IActionResult Models()
        {
            return View();
        }

        public IActionResult Views() 
        {
            return View();
        }

        public IActionResult Controllers()
        {
            return View();
        }

        public IActionResult Privacy() // this action returns the \Views\Home\Privacy.cshtml page
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
