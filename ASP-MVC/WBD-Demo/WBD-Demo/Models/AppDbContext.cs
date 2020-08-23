using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     ID = 1,
                     Name = "Fernando Torres",
                     Department = Dept.Player,
                     Email = "lfc.torres@gmail.com",
                     Avatarpath = "~/images/avatar_torres.png"
                 },
                new Employee()
                {
                    ID = 2,
                    Name = "Steven Gerrard",
                    Department = Dept.Coach,
                    Email = "lfc.gerrard@gmail.com",
                    Avatarpath = "~/images/avatar_gerrard.png"
                }
                 //new Employee()
                 //{
                 //    ID = 3,
                 //    Name = "Lucas Levi",
                 //    Department = Dept.Assistant,
                 //    Email = "lfc.lucaslevi@gmail.com",
                 //    Avatarpath = "~/images/no_avatar_employee.png"
                 //}
                );
        }
    }
}
