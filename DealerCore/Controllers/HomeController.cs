using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using DealerCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace DealerCore.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult SingOut()
        //{
        //    foreach (var cookie in Request.Cookies.Keys)
        //    {
        //        Response.Cookies.Delete(cookie);
        //    }
        //    return Redirect(_configuration["openIdInfo:redirectUri"]);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
