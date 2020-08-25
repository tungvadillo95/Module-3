using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationInformation.Models
{
    [Table("ward")]
    public class Ward : Entity
    {
        public int __district_id { get; set; }
    }
}
