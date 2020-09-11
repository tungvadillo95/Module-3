using MedicalDeclaration.Models;
using MedicalDeclaration.Models.Entity;
using MedicalDeclaration.Models.Entity.DiseaseSymptomsAndExposureHistory;
using MedicalDeclaration.Models.Entity.VietNamDb;
using MedicalDeclaration.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Service
{
    public class MedicalDeclarationService : IMedicalDeclarationService
    {
        private readonly MedicalDeclarationDb medicalDeclarationDb;

        public MedicalDeclarationService(MedicalDeclarationDb medicalDeclarationDb)
        {
            this.medicalDeclarationDb = medicalDeclarationDb;
        }

        public int CreateContactAdd(ContactAddress contactAddress)
        {
            medicalDeclarationDb.ContactAdds.Add(contactAddress);
            return medicalDeclarationDb.SaveChanges();
        }

        public int CreateDSAEH(DiseaseSymptomsAndExposureHistory dSAEH)
        {
            medicalDeclarationDb.DiseaseSymptomsAndExposureHistorys.Add(dSAEH);
            return medicalDeclarationDb.SaveChanges();
        }

        public int CreatePersonalInfo(PersonalInfomation personalInfo)
        {
            medicalDeclarationDb.PersonalInfos.Add(personalInfo);
            return medicalDeclarationDb.SaveChanges();
        }

        public CreateTravelInformationView CreateTravelInfo(CreateTravelInformationView model)
        {
            var newTravelInfo = new TravelInfo()
            {
                OtherVehicles = model.OtherVehicles,
                VehicleNumber = model.VehicleNumber,
                SeatsNumber = model.SeatsNumber,
                DepartureDay = model.DepartureDay(),
                EntryDay = model.EntryDay(),
                TravelHistory = model.TravelHistory,
                DepartureLocation_ProvinceId = model.DepartureLocation_ProvinceId,
                PlaceOfDestination_ProvinceId = model.PlaceOfDestination_ProvinceId
            };
            medicalDeclarationDb.TravelInfos.Add(newTravelInfo);
            medicalDeclarationDb.SaveChanges();
            if(model.Vehicles != null)
            {
                var modelList = new List<InfomationVehicle>();
                modelList = model.Vehicles.Select(v => new InfomationVehicle()
                {
                    VehiclesId = v,
                    TravelInformationId = newTravelInfo.TravelInformationId
                }).ToList();
                medicalDeclarationDb.InfomationVehicles.AddRange(modelList);
                medicalDeclarationDb.SaveChanges();
            }
            model.TravelInformationId = newTravelInfo.TravelInformationId;
            return model;

        }

        public IEnumerable<District> GetDistricts(int provinceId)
        {
            return medicalDeclarationDb.Districts.Where(e => e._province_id == provinceId);
        }

        public IEnumerable<Gate> GetGates()
        {
            return medicalDeclarationDb.Gates;
        }

        public IEnumerable<Gender> GetGenders()
        {
            return medicalDeclarationDb.Genders;
        }

        public IEnumerable<Province> GetProvinces()
        {
            return medicalDeclarationDb.Provinces;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return medicalDeclarationDb.Vehicles;
        }

        public IEnumerable<Ward> GetWards(int districtId = 0, int provinceId = 0)
        {
            if (provinceId != 0 && districtId != 0)
            {
                return medicalDeclarationDb.Wards.Where(e => e._province_id == provinceId && e._district_id == districtId);
            }
            else if (districtId != 0)
            {
                return medicalDeclarationDb.Wards.Where(e => e._district_id == districtId);
            }
            else if (provinceId != 0)
            {
                return medicalDeclarationDb.Wards.Where(e => e._province_id == provinceId);
            }
            return medicalDeclarationDb.Wards;
        }
    }
}
