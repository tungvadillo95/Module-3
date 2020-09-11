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
   public interface IMedicalDeclarationService
    {
        IEnumerable<Gate> GetGates();
        IEnumerable<Gender> GetGenders();
        int CreatePersonalInfo(PersonalInfomation personalInfo);
        IEnumerable<Vehicle> GetVehicles();
        IEnumerable<Province> GetProvinces();
        IEnumerable<District> GetDistricts(int provinceId);
        IEnumerable<Ward> GetWards(int districtId, int provinceId);
        CreateTravelInformationView CreateTravelInfo(CreateTravelInformationView model);
        int CreateContactAdd(ContactAddress contactAddress);
        int CreateDSAEH(DiseaseSymptomsAndExposureHistory dSAEH);
    }
}
