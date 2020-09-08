using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class EmployeeLanguage
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
