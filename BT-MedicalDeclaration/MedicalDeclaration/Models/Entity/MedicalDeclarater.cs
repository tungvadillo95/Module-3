using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    public class MedicalDeclarater
    {
        [Key]
        public int MedicalDeclaraterId { get; set; }
        public PersonalInfomation PersonalInfomation { get; set; }
        public TravelInfo TravelInformation { get; set; }
    }
}
