using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter.Models
{
    public class IndexModel 
    {
        [BindProperty(Name = "Rate", SupportsGet = true)]
        public int Rate { get; set; }
        [BindProperty(Name = "Usd", SupportsGet = true)]
        public int Usd { get; set; }
        [BindProperty(Name = "Vnd", SupportsGet = true)]
        public int Vnd { get; set; }
   
    }
}
