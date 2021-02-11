using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreyAssignment4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
               List<string> resList = new List<string>();

                foreach (Restaurant r in Restaurant.GetRestaurant())
                {
                    resList.Add($"#{r.ResRanking}: {r.ResName} located at {r.ResAddress}. The favorite dish is: {r.FavDish}. You can contact them here: {r.ResPhone} or their website: {r.ResLink}");
                }

                return View(resList); 
            }
            else
            {
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult ResForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResForm(EntryResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddEntry(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
        }
        public IActionResult RestaurantSuggestions()
        {
            return View(TempStorage.Entries);
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
