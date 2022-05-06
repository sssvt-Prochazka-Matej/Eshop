using EshopArmy.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Interfaces
{
    public interface IBasketService
    {
        ICollection<Basket> GetList();

        void AddToBasket(Basket basket);

        void Remove(Basket basket);

        public Basket GetBasket(int id);

        public void Edit(Basket basket);
    }
}
