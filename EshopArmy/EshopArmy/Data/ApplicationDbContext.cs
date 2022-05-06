using EshopArmy.BusinessObjects;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EshopArmy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Basket> Basket { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }

}
