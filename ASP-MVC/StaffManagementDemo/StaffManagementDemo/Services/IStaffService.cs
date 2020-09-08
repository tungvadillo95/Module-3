using StaffManagementDemo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagementDemo.Services
{
    public interface IStaffService
    {
        IEnumerable<Province> GetProvinces();
        IEnumerable<District> GetDistricts(int provinceId);
        IEnumerable<Ward> GetWards(int districtId, int provinceId);
        int CreateStaff(Staff staff);
    }
}
