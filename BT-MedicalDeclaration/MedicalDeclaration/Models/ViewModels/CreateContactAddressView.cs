using MedicalDeclaration.Models.Entity.VietNamDb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.ViewModels
{
    public class CreateContactAddressView
    {
        public CreateContactAddressView()
        {
            Provinces = new List<Province>();
            Districts = new List<District>();
            Wards = new List<Ward>();
        }
        public IEnumerable<Province> Provinces { get; set; }
        public IEnumerable<District> Districts { get; set; }
        public IEnumerable<Ward> Wards { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"(09|03|07[1|2|3|4|5|6|7|8|9])+([0-9]{8})\b", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Tỉnh/Thành phố")]
        public int ProvinceId { get; set; }
        [Display(Name = "Quận/Huyện")]
        public int DistrictId { get; set; }
        [Display(Name = "Phường/Xã")]
        public int WardId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
    }
}
