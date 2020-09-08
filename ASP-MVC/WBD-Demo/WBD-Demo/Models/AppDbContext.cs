using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
               .HasOne<Department>(e => e.Department)
               .WithMany(d => d.Employees)
               .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<EmployeeLanguage>()
                .HasKey(el => new { el.EmployeeId, el.LanguageId });

            modelBuilder.Entity<Department>().HasData(
                 new Department()
                 {
                     DepartmentId = 1,
                     DepartmentName = "IT"
                 },
                  new Department()
                  {
                      DepartmentId = 2,
                      DepartmentName = "HR"
                  },
                   new Department()
                   {
                       DepartmentId = 3,
                       DepartmentName = "Payroll"
                   },
                    new Department()
                    {
                        DepartmentId = 4,
                        DepartmentName = "Sale"
                    }
                 );
            modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     ID = 1,
                     Name = "Fernando Torres",
                     DepartmentId = 1,
                     Email = "lfc.torres@gmail.com",
                     Avatarpath = "~/images/avatar_torres.png"
                 },
                new Employee()
                {
                    ID = 2,
                    Name = "Steven Gerrard",
                    DepartmentId = 2,
                    Email = "lfc.gerrard@gmail.com",
                    Avatarpath = "~/images/avatar_gerrard.png"
                }
            );
            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    LanguageId = 1,
                    LanguageName = "English"
                },
                new Language()
                {
                    LanguageId = 2,
                    LanguageName = "Vietnamese"
                },
                new Language()
                {
                    LanguageId = 3,
                    LanguageName = "Japanese"
                },
                new Language()
                {
                    LanguageId = 4,
                    LanguageName = "Korean"
                }
                );
            modelBuilder.Entity<EmployeeLanguage>().HasData(
                new EmployeeLanguage()
                {
                    EmployeeId = 1,
                    LanguageId = 1
                },
                new EmployeeLanguage()
                {
                    EmployeeId = 1,
                    LanguageId = 2
                },
                 new EmployeeLanguage()
                 {
                     EmployeeId = 2,
                     LanguageId = 3
                 },
                 new EmployeeLanguage()
                 {
                     EmployeeId = 2,
                     LanguageId = 4
                 }
                );
        }
    }
}
