using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserLogin.Models
{
    public class LoginModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Required")]
        public string Username { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        public string  Password { get; set; }

       
    }
}