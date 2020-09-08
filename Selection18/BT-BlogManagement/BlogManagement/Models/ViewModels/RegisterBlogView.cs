using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Models.ViewModels
{
    public class RegisterBlogView
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tên Blog")]
        [MaxLength(50)]
        public string BlogName { get; set; }
        [MaxLength(300)]
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Giới thiệu")]
        public string Present { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public CategoryBlog Category { get; set; }
    }
}
