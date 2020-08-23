using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
        Employee Get(int ID);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        bool Delete(int ID);
    }
}
