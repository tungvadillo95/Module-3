using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class EmployeeDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Avatarpath { get; set; }
        public List<Language> Languages { get; set; }
    }
}
