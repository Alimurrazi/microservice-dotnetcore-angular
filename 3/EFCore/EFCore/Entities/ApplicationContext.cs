using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = Guid.NewGuid(),
                Name = "John Doe",
                Age = 30
            }, new Student
            {
                StudentId = Guid.NewGuid(),
                Name = "Jane Doe",
                Age = 25
            });
        }
    }
}
