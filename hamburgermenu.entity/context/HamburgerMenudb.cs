using hamburgermenu.entites;
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

       public DbSet<HamburgerName> hamburgermenus { get; set; }
       
       public DbSet<Category> categories { get; set; }



    }
}
