using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EshopArmy.BusinessObjects;
using EshopArmy.Data;
using EshopArmy.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EshopArmy.Repos
{
    public class WeaponRepo : IWeaponRepo
    {
        private readonly ApplicationDbContext context;

        public WeaponRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Weapon weapon)
        {
            context.Weapons.Add(weapon);

            context.SaveChanges();
        }

        public void Update(Weapon weapon)
        {
            context.Entry(weapon).State = ((weapon.Id == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }

        public ICollection<Weapon> GetList()
        {
            var query = from w in context.Weapons select w;

            var weapons = query.ToList<Weapon>();

            return weapons;
        }

        public Weapon LoadWeapon(Weapon weapon)
        {
            return context.Weapons.Find(weapon.Id);
        }

        public void Remove(Weapon weapon)
        {
            context.Entry(weapon).State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
