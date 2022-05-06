using EshopArmy.BusinessObjects;
using EshopArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopArmy.Services
{
    public class WeaponService : IWeaponService
    {
        private readonly IWeaponRepo weaponRepo;



        public WeaponService(IWeaponRepo weaponRepo)
        {
            this.weaponRepo = weaponRepo;
        }

        public ICollection<Weapon> GetList()
        {
            return this.weaponRepo.GetList();
        }
        
        public void DeleteWeapon(Weapon weapon)
        {
            this.weaponRepo.Remove(weapon);
        }

        public Weapon GetWeapon(int id)
        {
            Weapon w = new Weapon();
            w.Id = id;
            return this.weaponRepo.LoadWeapon(w);
        }

        public Weapon SaveWeapon(Weapon weapon)
        {
            if (weapon.Id != 0)
            {
                // User already exists.
                // UPDATE
                this.weaponRepo.Update(weapon);
            }
            else
            {
                // Create a new user.
                // INSERT
                this.weaponRepo.Add(weapon);
            }
            return weapon;
        }
    }
}
