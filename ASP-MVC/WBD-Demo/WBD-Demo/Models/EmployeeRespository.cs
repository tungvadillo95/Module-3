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
                    Fullname = "Fernando Torres",
                    Department = "Soccer Player",
                    Email = "lfc.torres@gmail.com",
                    Avatarpath = "~/images/avatar_torres.png"
                },
                new Employee()
                {
                    ID = 2,
                    Fullname = "Steven Gerrard",
                    Department = "Coach",
                    Email = "lfc.gerrard@gmail.com",
                    Avatarpath = "~/images/avatar_gerrard.png"
                },
            };
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
