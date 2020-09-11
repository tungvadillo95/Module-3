using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity.VietNamDb
{
    public class ContactAddress
    {
        [Key]
        public int ContactAddressId { get; set; }
        [ForeignKey("Provinces")]
        public int ProvinceId { get; set; }
        [ForeignKey("Districts")]
        public int DistrictId { get; set; }
        [ForeignKey("Wards")]
        public int WardId { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
    }
}
