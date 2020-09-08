using CustomerManager.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models.ViewModels
{
    public class RegisterView
    {
        public RegisterView()
        {
            Provinces = new List<Province>();
        }
        public int Id { get; set; }
        public IEnumerable<Province> Provinces { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [MaxLength(30)]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"(09|01[2|6|8|9])+([0-9]{8})\b", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tỉnh/Thành phố")]
        public int ProvinceId { get; set; }
    }
}
