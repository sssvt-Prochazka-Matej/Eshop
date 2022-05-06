using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EshopArmy.BusinessObjects;
namespace EshopArmy.Interfaces
{
    public interface IBasketRepo
    {
        ICollection<Basket> GetList();

        void Add(Basket basket);

        void Remove(Basket basket);

        public Basket LoadBasket(Basket basket);

        public void Update(Basket basket);
    }
}
