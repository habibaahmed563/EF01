using EF01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Context
{
    internal class AppDbContext : DbContext
    {
        //Microsoft.EntityframeworkCore


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppG03 ; Trusted_Connection = True");
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
