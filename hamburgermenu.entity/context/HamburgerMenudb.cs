using hamburgermenu.entites;
using hamburgermenu.entitiy.entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgermenu.context
{
    public class HamburgerMenudb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R937SDA\\TEW_SQLEXPRESS;Database=HamburgerMenudb;Trusted_Connection=True;TrustServerCertificate=true");

        }


        public DbSet<Drinks> Drinks { get; set; }   

        public DbSet<HamburgerMenuName> hamburgermenunames { get; set; }

        public DbSet<MenuList> MenuLists { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Sauce> Sauces { get; set;}

        public DbSet<User> Users { get; set; }  

    }
}
