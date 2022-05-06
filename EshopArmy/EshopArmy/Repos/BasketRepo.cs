using EshopArmy.BusinessObjects;
using EshopArmy.Data;
using EshopArmy.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Repos
{
    public class BasketRepo : IBasketRepo
    {
        private readonly ApplicationDbContext context;

        public BasketRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Basket basket)
        {
            context.Basket.Add(basket);

            context.SaveChanges();
        }

        public ICollection<Basket> GetList()
        {
            var basket = context.Basket
                .Include(c => c.Weapon)
                .ToList();

            return basket;
        }

        public void Remove(Basket basket)
        {
            context.Entry(basket).State = EntityState.Deleted;

            context.SaveChanges();
        }

        public Basket LoadBasket(Basket basket)
        {
            return context.Basket.Find(basket.ID);
        }

        public void Update(Basket basket)
        {          
            context.Entry(basket).State = ((basket.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }
    }
}
