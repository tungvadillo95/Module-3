using MedicalDeclaration.Models.Entity;
using MedicalDeclaration.Models.Entity.VietNamDb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.ViewModels
{
    public class CreateTravelInformationView
    {
        public CreateTravelInformationView()
        {
            Provinces = new List<Province>();
        }
        public int TravelInformationId { get; set; }
        public IEnumerable<Province> Provinces { get; set; }
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
        [Required(ErrorMessage = "Bạn chưa chọn tỉnh khởi hành")]
        public int DepartureLocation_ProvinceId { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn tỉnh đến")]
        public int PlaceOfDestination_ProvinceId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập lịch sử đi lại giữa các tỉnh")]
        [MaxLength(500)]
        public string TravelHistory { get; set; }

        public DateTime DepartureDay()
        {
            var dateString = DepartureDay_Year + "-" + DepartureDay_Month + "-" + EntryDay_Date;
            return DateTime.Parse(dateString);
        }
        public DateTime EntryDay()
        {
            var dateString = EntryDay_Year + "-" + EntryDay_Month + "-" + EntryDay_Date;
            return DateTime.Parse(dateString);
        }
    }
}
