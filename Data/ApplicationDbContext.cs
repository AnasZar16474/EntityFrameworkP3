using EntityFrameworkP3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkP3.Data
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=task2;Trusted_Connection=True;TrustServerCertificate=True");
        }
    
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; } 
    }
   

}
