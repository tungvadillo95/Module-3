using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationFormLogin.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Title is required")]

        public string Password { get; set; }
    }
}
