using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.ViewModels
{
    public class UserEditViewModel 
    {
        public string UserId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string RolesId { get; set; }
    }
}
