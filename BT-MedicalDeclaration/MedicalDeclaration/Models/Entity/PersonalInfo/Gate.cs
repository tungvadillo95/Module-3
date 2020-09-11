using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    [Table("Gate")]
    public class Gate
    {
        public int GateId { get; set; }
        [MaxLength(200)]
        public string GateName { get; set; }
        //public int PersonalInfoId { get; set; }
        //public PersonalInfomation PersonalInfomation { get; set; }
    }
}
