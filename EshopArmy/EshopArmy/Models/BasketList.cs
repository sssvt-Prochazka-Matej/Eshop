using EshopArmy.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Models
{
    public class BasketList
    {
        public ICollection<Basket> Basketlist { get; set; }
    }
}
