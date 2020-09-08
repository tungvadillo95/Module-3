using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class Department
    {
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
