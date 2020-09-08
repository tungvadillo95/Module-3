using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.ViewModels;

namespace WBD_Demo.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
        EmployeeDetailViewModel Get(int ID);
        CreateEmployeeViewModel Create(CreateEmployeeViewModel employee);
        EditEmployeeViewModel Edit(EditEmployeeViewModel employee);
        bool Delete(int ID);
    }
}
