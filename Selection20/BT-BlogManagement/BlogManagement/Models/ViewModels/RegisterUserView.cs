using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Models.ViewModels
{
    public class RegisterUserView
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tên đăng nhập")]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Mật khẩu không khớp")]
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
