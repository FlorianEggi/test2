using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string mail { get; set; }

        //[Required]
        //[StringLength(25)]
        //public string FirstName { get; set; }

        //[Required]
        //[StringLength(25)]
        //public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        //[Required]
        //[StringLength(50)]
        //public string ConfirmPassword { get; set; }
    }
}
