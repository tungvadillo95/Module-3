using MedicalDeclaration.Models.Entity;
using MedicalDeclaration.Models.Entity.VietNamDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models
{
    public class MedicalDeclarationDb : DbContext
    {
        public MedicalDeclarationDb(DbContextOptions<MedicalDeclarationDb> options) : base(options)
        {

        }
        public DbSet<MedicalDeclarater> MedicalDeclaraters { get; set; }
        public DbSet<PersonalInfomation> PersonalInfos { get; set; }
        public DbSet<InfomationVehicle> InfomationVehicles { get; set; }
        public DbSet<ContactAddress> ContactAdds { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<TravelInfo> TravelInfos { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<Gate>();
            //modelBuilder.Ignore<Gender>();
            //modelBuilder.Ignore<PersonalInfomation>();
            //modelBuilder.Ignore<Province>();
            //modelBuilder.Ignore<District>();
            //modelBuilder.Ignore<Ward>();
            //modelBuilder.Ignore<TravelInfo>();
            //modelBuilder.Ignore<Vehicle>();
            //modelBuilder.Ignore<InfomationVehicle>();
            modelBuilder.Ignore<MedicalDeclarater>();

            modelBuilder.Entity<InfomationVehicle>()
                .HasKey(iv => new { iv.TravelInformationId, iv.VehiclesId });


        }
    }
}
