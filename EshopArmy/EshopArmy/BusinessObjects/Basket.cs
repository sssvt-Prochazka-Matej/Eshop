using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.BusinessObjects
{
    public class Basket
    {
        [Key]
        public int ID { get; set; }

        public string UserID { get; set; }
        
        public int Ammout { get; set; }
        
        public Weapon Weapon { get; set; }


    }
}
