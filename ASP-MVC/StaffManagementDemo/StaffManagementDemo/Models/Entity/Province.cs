using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagementDemo.Models.Entity
{
    [Table("province")]
    public class Province
    {
        [Key]
        public int id { get; set; }
        public string _name { get; set; }
        public string _code { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
