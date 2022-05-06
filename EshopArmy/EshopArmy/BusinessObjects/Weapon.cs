using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.BusinessObjects
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Price { get; set; }
        public string UnitsInStorage { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }
        
    }
}
