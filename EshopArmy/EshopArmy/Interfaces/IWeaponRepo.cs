using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EshopArmy.BusinessObjects;

namespace EshopArmy.Interfaces
{
    public interface IWeaponRepo
    {
        Weapon LoadWeapon(Weapon weapon);

        ICollection<Weapon> GetList();

        void Add(Weapon weapon);

        void Remove(Weapon weapon);

        void Update(Weapon weapon);
    }
}
