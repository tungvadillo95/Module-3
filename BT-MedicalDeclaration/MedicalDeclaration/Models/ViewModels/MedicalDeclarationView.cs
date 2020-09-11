using MedicalDeclaration.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.ViewModels
{
    public class MedicalDeclarationView
    {
        // PersonalInfo
        public MedicalDeclarationView()
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

        // TravelInfo
        public List<int> Vehicles { get; set; }
        [MaxLength(2000)]
        public string OtherVehicles { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số hiệu phương tiện")]
        [Display(Name = "Số hiệu phương tiện")]
        [MaxLength(500)]
        public string VehicleNumber { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số ghế")]
        [Display(Name = "Số ghế")]
        [MaxLength(500)]
        public string SeatsNumber { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn ngày khởi hành")]
        public string DepartureDay_Date { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn tháng khởi hành")]
        public string DepartureDay_Month { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn năm khởi hành")]
        public string DepartureDay_Year { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn ngày nhập cảnh")]
        public string EntryDay_Date { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn tháng nhập cảnh")]
        public string EntryDay_Month { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn năm nhập cảnh")]
        public string EntryDay_Year { get; set; }
        [Required(ErrorMessage = "Bạn chưa tỉnh khởi hành")]
        public int DepartureLocation_ProvinceId { get; set; }
        [Required(ErrorMessage = "Bạn chưa tỉnh đến")]
        public int PlaceOfDestination_ProvinceId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập lịch sử đi lại giữa các tỉnh/quốc gia")]
        [MaxLength(500)]
        public string TravelHistory { get; set; }
    }
}
