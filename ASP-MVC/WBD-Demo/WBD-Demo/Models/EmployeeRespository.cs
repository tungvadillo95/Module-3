using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.ViewModels;

namespace WBD_Demo.Models
{
    public class EmployeeRespository : IEmployeeRepository
    {
        //private List<Employee> employees;
        //public EmployeeRespository()
        //{
        //    employees = new List<Employee>()
        //    {
        //        new Employee()
        //        {
        //            ID = 1,
        //            Name = "Fernando Torres",
        //            DepartmentId = 1,
        //            Email = "lfc.torres@gmail.com",
        //            Avatarpath = "~/images/avatar_torres.png"
        //        },
        //        new Employee()
        //        {
        //            ID = 2,
        //            Name = "Steven Gerrard",
        //            DepartmentId = 2,
        //            Email = "lfc.gerrard@gmail.com",
        //            Avatarpath = "~/images/avatar_gerrard.png"
        //        },
        //    };
        //}

        //public Employee Create(Employee employee)
        //{
        //    employee.ID = employees.Max(e => e.ID) + 1;
        //    employee.Avatarpath = "~/images/no_avatar_employee.png";
        //    employees.Add(employee);
        //    return employee;
        //}

        //public bool Delete(int ID)
        //{
        //    var delEmployee = Get(ID);
        //    if (delEmployee != null)
        //    {
        //        employees.Remove(delEmployee);
        //        return true;
        //    }
        //    return false;
        //}

        //public Employee Edit(Employee employee)
        //{
        //    var editEmployee = Get(employee.ID);
        //    editEmployee.Name = employee.Name;
        //    editEmployee.Email = employee.Email;
        //    editEmployee.DepartmentId = employee.DepartmentId;
        //    return editEmployee;
        //}

        //public EmployeeDetailViewModel Get(int ID)
        //{
        //    return employees.FirstOrDefault(e => e.ID == ID);
        //}

        //public IEnumerable<Employee> Gets()
        //{
        //    return employees;
        //}
        public Employee Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public CreateEmployeeViewModel Create(CreateEmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Employee Edit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public EditEmployeeViewModel Edit(EditEmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeDetailViewModel Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Gets()
        {
            throw new NotImplementedException();
        }
    }
}
