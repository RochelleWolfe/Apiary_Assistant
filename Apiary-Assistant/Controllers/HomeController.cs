using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Apiary_Assistant.Models;
using Apiary_Assistant.DAL;

namespace Apiary_Assistant.Controllers
{
    public class HomeController : Controller
    {
        private IHiveDAL _dal;

        public HomeController(IHiveDAL dal)
        {
            _dal = dal;
        }

        public IActionResult Index()
        {
            var hives = _dal.GetStartHives();
            return View(hives); //when we have data, pass Hives as a parameter in this View
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
