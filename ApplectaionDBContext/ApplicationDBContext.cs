using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1EF.Models;

namespace Task1EF.ApplectaionDBContext
{
    internal class ApplicationDBContext :DbContext
    {
        public DbSet<Product>  Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;DataBase=Task1EFDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
