using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Models.ViewModels
{
    public class RegisterPostView
    {
        public int PostId { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Tên Post")]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        public string Content { get; set; }
        public string DateUpload { get; set; }
        public int BlogId { get; set; }
    }
}
