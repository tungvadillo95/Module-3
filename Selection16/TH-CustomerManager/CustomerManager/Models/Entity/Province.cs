using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models.Entity
{
    [Table("province")]
    public class Province
    {
        public int id { get; set; }
        public string _name { get; set; }
        public string _code { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
