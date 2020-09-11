using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    [Table("PersonalInfo")]
    public class PersonalInfomation
    {
        [Key]
        public int PersonalInfoId { get; set; }
        //public int MedicalDeclaraterId { get; set; }
        //public MedicalDeclarater MedicalDeclarater { get; set; }
        public int GateId { get; set; }
        [MaxLength(100)]
        public string PersonalName { get; set; }
        [MaxLength(20)]
        public string YearOfBirth { get; set; }
        public int GenderId { get; set; }
        [MaxLength(100)]
        public string PassportNumber { get; set; }
    }
}
