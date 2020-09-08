using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Phải nhập họ tên.")]
        [MaxLength(20, ErrorMessage ="Tên nhập vào không được vượt quá 20 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phải nhập email.")]
        [Display(Name = "Office Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"
                            ,ErrorMessage ="Email nhập không hợp lệ")]
        public string Email { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Avatarpath { get; set; }
        public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
    }
}
