using EshopArmy.BusinessObjects;
using EshopArmy.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EshopArmy.Controllers
{
    [Route("Detail")]
    public class DetailController : Controller
    {
        private readonly IWeaponService weaponService;
        private readonly IBasketService basketService;       

        public DetailController(IWeaponService weaponService, IBasketService basketService)
        {
            this.weaponService = weaponService;
            this.basketService = basketService;           
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("DetailWeapon/{id:int}")]
        public IActionResult DetailWeapon([FromRoute] int id)
        {
            Weapon weapon = this.weaponService.GetWeapon(id);

            return View("DetailWeapon", weapon);

        }

        [HttpGet("AddToBasket/{id:int}")]
        public IActionResult AddToBasket([FromRoute] int id)
        {
            Weapon weapon = this.weaponService.GetWeapon(id);

            Basket basket = new Basket();
            basket.ID = 0;
            basket.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            basket.Ammout = 1;
            basket.Weapon = weapon;

            this.basketService.AddToBasket(basket);

            return Redirect("/basket");
        }
    }
}
