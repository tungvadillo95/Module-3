using Microsoft.EntityFrameworkCore;
using PhoneManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneManagement.DAL
{
    public class DataContext : DbContext

    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options)

            : base(options) { }

        public DbSet<Phone> Phones { get; set; }

    }

}
