using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserLogin.Models
{
    public class EmployeeModel
    {
        [Range(100000,999999,ErrorMessage ="Employee Id Must be lest than 6 digits.")]
        [Display(Name ="Employee Id")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First Name is Mandatory")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Mandatory")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Compare("Email",ErrorMessage ="Password does not match")]
        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string ConfrirmPassword { get; set; }

    }
}