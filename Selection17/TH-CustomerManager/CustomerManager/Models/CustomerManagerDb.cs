using CustomerManager.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models
{
    public class CustomerManagerDb : DbContext
    {
        public CustomerManagerDb(DbContextOptions<CustomerManagerDb> options) : base(options)
        {

        }
        public DbSet<Province> Provinces { get; set; }

        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<Province>();

            modelBuilder.Entity<Customer>()
            .HasOne<Province>(s => s.Province)
            .WithMany(p => p.Customers)
            .HasForeignKey(c => c.ProvinceId);

        }

    }
}
