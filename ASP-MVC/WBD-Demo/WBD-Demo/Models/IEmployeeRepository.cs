using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
    }
}
