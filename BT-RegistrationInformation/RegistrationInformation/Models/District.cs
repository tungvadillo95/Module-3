using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationInformation.Models
{
    [Table("district")]
    public class District : Entity
    {
        public int _province_id { get; set; }
    }
}
