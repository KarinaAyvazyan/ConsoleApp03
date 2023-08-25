using ConsoleApp03.Entities;
using ConsoleApp3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public class MyShopDbContext:DbContext
    {
        public DbSet<Product> Products { get;set; }
        public DbSet<User> Users { get;set; }  
        
        public DbSet<Order> Orders { get;set; } 

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =(localdb)\\mssqllocaldb;Database=MyShopDbEntity;Trusted_Connection=True;");

        }
    }
}
