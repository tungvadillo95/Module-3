using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.Models;

namespace WBD_Demo.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Phải nhập họ tên.")]
        [MaxLength(20, ErrorMessage = "Tên nhập vào không được vượt quá 20 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phải nhập email.")]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$"
                            , ErrorMessage = "Email nhập không hợp lệ")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
