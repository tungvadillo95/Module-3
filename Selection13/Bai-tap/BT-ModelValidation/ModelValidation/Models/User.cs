using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Length must be between 6 to 32 characters")]
        public string Password { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a positive number")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email entered is not in the correct formatd")]
        public string Email { get; set; }
    }
}
