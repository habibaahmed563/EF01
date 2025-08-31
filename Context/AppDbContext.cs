using EF01.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Context
{
    internal class AppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(E => E.Id).HasColumnName("StudID");
            modelBuilder.Entity<Stud_Course>().HasKey(E => new { E.Stud_Id, E.Course_Id });
            modelBuilder.Entity<Course_inst>().HasKey(E => new { E.inst_Id, E.Course_Id });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI_DB ; Trusted_Connection = True");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Course_inst> Course_Insts { get; set; }
        public DbSet<Instructor> instructors { get; set; }
    }
}
