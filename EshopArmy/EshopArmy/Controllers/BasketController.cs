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
    [Route("Basket")]
    [Authorize]
    public class BasketController : Controller
    {
        private readonly IBasketService basketService;

        public BasketController(IBasketService basketService)
        {
            this.basketService = basketService;
        }

        public IActionResult Index()
        {
            return View(new BasketList { Basketlist = this.basketService.GetList() });
        }

        [HttpGet("Remove/{id:int}")]
        public IActionResult Remove([FromRoute] int id)
        {
            Basket basket = this.basketService.GetBasket(id);

            this.basketService.Remove(basket);

            return RedirectToAction("index");
        }

        [HttpPost("Save")]
        public IActionResult Save([FromForm] int amount, [FromForm] int id)
        {
            Basket temp = this.basketService.GetBasket(id);
            temp.Ammout = amount;

            this.basketService.Edit(temp);

            return RedirectToAction("index");
        }
    }
}
