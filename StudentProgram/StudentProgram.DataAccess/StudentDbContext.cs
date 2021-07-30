using Microsoft.EntityFrameworkCore;
using StudentProgram.Entities;
using System;

namespace StudentProgram.DataAccess
{
    public class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=RAMAZAN; Database=DbStudent; uid=sa;pwd=password1;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
