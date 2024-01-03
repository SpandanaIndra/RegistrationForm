using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Shared
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required,It Should not be blank..!")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Minimum 4 characters")]
        [MaxLength(10, ErrorMessage = "Maximum of 10 characters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
      
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

       

       
    }
}
