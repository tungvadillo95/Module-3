using MedicalDeclaration.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.ViewModels
{
    public class CreatePersonalInfomationView
    {
        public CreatePersonalInfomationView()
        {
            Gates = new List<Gate>();
            Genders = new List<Gender>();
        }

        public IEnumerable<Gate> Gates { get; set; }
        public IEnumerable<Gender> Genders { get; set; }

        [Required(ErrorMessage = "Bạn chưa chọn cửa khẩu")]
        public int GateId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập họ tên")]
        [MaxLength(30)]
        public string PersonalName { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn năm sinh")]
        public string YearOfBirth { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn họ tên")]
        public int GenderId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập CMT, hộ chiếu")]
        public string PassportNumber { get; set; }
    }
}
