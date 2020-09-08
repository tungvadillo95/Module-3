using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.ViewModels
{
    public class EditEmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public string Avatarpath { get; set; }
        public List<int> Languages { get; set; }
    }
}
