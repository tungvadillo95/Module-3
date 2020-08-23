using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRespository()
        {
            employees = new List<Employee>()
            {
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
                },
            };
        }

        public Employee Create(Employee employee)
        {
            employee.ID = employees.Max(e => e.ID) + 1;
            employee.Avatarpath = "~/images/no_avatar_employee.png";
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int ID)
        {
            var delEmployee = Get(ID);
            if (delEmployee != null)
            {
                employees.Remove(delEmployee);
                return true;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmployee = Get(employee.ID);
            editEmployee.Name = employee.Name;
            editEmployee.Email = employee.Email;
            editEmployee.Department = employee.Department;
            return editEmployee;
        }

        public Employee Get(int ID)
        {
            return employees.FirstOrDefault(e => e.ID == ID);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
