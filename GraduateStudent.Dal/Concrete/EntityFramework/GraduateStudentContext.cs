using GraduateStudent.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Dal.Concrete
{
   
   public class GraduateStudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-9IQ5NO3T\SQLEXPRESS;Database=GraduateStudentDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Announcement> Announcements { get; set; }
    }
}
