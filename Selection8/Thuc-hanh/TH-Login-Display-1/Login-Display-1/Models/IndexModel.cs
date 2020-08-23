using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Display_1.Models
{
    public class IndexModel
    {
        //[BindProperty(Name = "Username", SupportsGet = true)]
        public string Username { get; set; }
        //[BindProperty(Name = "123123", SupportsGet = true)]
        public string Password { get; set; }
    }
}
