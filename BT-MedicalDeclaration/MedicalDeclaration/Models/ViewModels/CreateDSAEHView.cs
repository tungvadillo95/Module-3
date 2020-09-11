using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.ViewModels
{
    public class CreateDSAEHView
    {
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Sốt ")]
        public bool Fever { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Ho ")]
        public bool Cough { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Khó thở ")]
        public bool Sultry { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Đau họng ")]
        public bool SoreThroat { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Nôn/buồn nôn ")]
        public bool VomitingOrNausea { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Tiêu chảy ")]
        public bool Diarrhea { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Xuất huyết ngoài da ")]
        public bool BleedingFromTheSkin { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn triệu chứng")]
        [Display(Name = "Nổi ban ngoài da ")]
        public bool SkinRash { get; set; }
        [Display(Name = "Danh sách vắc-xin hoặc sinh phẩm được sử dụng")]
        [MaxLength(500)]
        public string VaccinesOrBiologicalsUsed { get; set; }

        [Required(ErrorMessage = "Bạn chưa chọn lịch sử phơi nhiễm")]
        [Display(Name = "Đến trang trại chăn nuôi / chợ buôn bán động vật sống / cơ sở giết mổ động vật / tiếp xúc động vật ")]
        public bool AnimalContact { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn lịch sử phơi nhiễm")]
        [Display(Name = "Tiếp xúc gần (<2m) với người mắc bệnh viêm đường hô hấp do nCoV ")]
        public bool CloseContact { get; set; }
    }
}
