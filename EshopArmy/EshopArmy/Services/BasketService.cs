using EshopArmy.BusinessObjects;
using EshopArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepo basketRepo;

        public BasketService(IBasketRepo basketRepo)
        {
            this.basketRepo = basketRepo;
        }

        public void AddToBasket(Basket basket)
        {
            ICollection<Basket> list = this.basketRepo.GetList();
            bool duplicate = false;
            int id = 0;

            foreach(var item in list)
            {
                if(item.Weapon.Id == basket.Weapon.Id)
                {
                    id = item.ID;
                    duplicate = true;
                }
            }


            if (duplicate)
            {
                Basket temp = GetBasket(id);
                temp.Ammout += 1;
                this.basketRepo.Update(temp);                
            }
            else if (basket.ID == 0) 
            {
                this.basketRepo.Add(basket);
            }
         
        }

        public void Edit(Basket basket)
        {
            this.basketRepo.Update(basket);
        }

        public ICollection<Basket> GetList()
        {
            return this.basketRepo.GetList();
        }

        public void Remove(Basket basket)
        {
            this.basketRepo.Remove(basket);
        }

        public Basket GetBasket(int id)
        {
            Basket b = new Basket();
            b.ID = id;
            return this.basketRepo.LoadBasket(b);
        }


    }
}
