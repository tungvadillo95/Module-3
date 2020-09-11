using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    [Table("Gender")]
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [MaxLength(15)]
        public string GenderName { get; set; }
        //public int PersonalInfoId { get; set; }
        //public PersonalInfomation PersonalInfomation { get; set; }
    }
}
