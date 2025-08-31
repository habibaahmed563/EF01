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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Employee>().HasKey("EmpId");
            ////    modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);
            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Name)
            //    .IsRequired()
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(50)
            //    .HasColumnName("EmployeeName");

            //modelBuilder.Entity<Employee>().Property(E => E.Age).IsRequired(false);

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("Money");

            //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);

            //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValueSql("GetDate()");



            modelBuilder.Entity<Employee>(E =>
            { 
                E
                .Property(E => E.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .HasColumnName("EmployeeName");

                E.Property(E => E.Age).IsRequired(false);

                E.Property(E => E.Salary).HasColumnType("Money");

                E.Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);

                E.Property(E => E.DateOfCreation).HasDefaultValueSql("GetDate()");
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppG03 ; Trusted_Connection = True");
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
