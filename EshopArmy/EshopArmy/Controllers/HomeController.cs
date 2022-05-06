using EshopArmy.Interfaces;
using EshopArmy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IWeaponService weaponService;

        public HomeController(ILogger<HomeController> logger, IWeaponService weaponService)
        {
            _logger = logger;
            this.weaponService = weaponService;
        }


       

        public IActionResult Index()
        {
            return View(new WeaponList {Weapons = this.weaponService.GetList() });
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
