using EshopArmy.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Interfaces
{
    public interface IWeaponService
    {
        Weapon GetWeapon(int id);
        ICollection<Weapon> GetList();

        public Weapon SaveWeapon(Weapon weapon);

        public void DeleteWeapon(Weapon weapon);

    }
}
