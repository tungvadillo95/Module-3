using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class Language
    {
        [Required]
        public int LanguageId { get; set; }
        [Required]
        [MaxLength(50)]
        public string LanguageName { get; set; }
        public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
    }
}
