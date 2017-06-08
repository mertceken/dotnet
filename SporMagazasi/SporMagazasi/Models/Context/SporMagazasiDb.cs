using SporMagazasi.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SporMagazasi.Models.Context
{
    public class SporMagazasiDb:DbContext
    {

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

         public SporMagazasiDb()
        {
            Database.Connection.ConnectionString = "server=KADERERDOGAN;database=SporMagazam;Integrated Security=True";
        }

         public DbSet<User> Users { get; set; }
         public DbSet<Product> Products { get; set; }
         public DbSet<Category> Categorys{ get; set; }
         public DbSet<Siparis> Siparis { get; set; }
    }
}