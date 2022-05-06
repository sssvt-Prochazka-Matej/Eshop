using EshopArmy.BusinessObjects;
using EshopArmy.Interfaces;
using EshopArmy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Controllers
{
    [Route("Manage")]
    [Authorize(Roles ="Admin")]
    public class ManageController : Controller
    {
        private readonly IWeaponService weaponService;

        public ManageController(IWeaponService weaponService)
        {
            this.weaponService = weaponService;
        }

        public IActionResult Index()
        {
            return View(new WeaponList { Weapons = this.weaponService.GetList() });
        }

        [HttpGet("Delete/{id:int}")]
        public IActionResult Delete([FromRoute ]int id)
        {
            Weapon weapon = this.weaponService.GetWeapon(id);

            this.weaponService.DeleteWeapon(weapon);

            return RedirectToAction("Index");
        }

        [HttpGet("EditWeapon")]
        public IActionResult EditWeapon()
        {         
            return View("/Views/Manage/EditWeapon.cshtml", new Weapon());
        }

        [HttpGet("EditWeapon/{id:int}")]
        public IActionResult EditWeapon([FromRoute] int id)
        {
            Weapon weapon = this.weaponService.GetWeapon(id);

            return View("/Views/Manage/EditWeapon.cshtml", weapon);
        }

        
        [HttpPost("EditWeapon")]
        public IActionResult EditWeapon([FromForm] Weapon weapon)
        {

            this.weaponService.SaveWeapon(weapon);

            return RedirectToAction("Index");
        }
    }
}
