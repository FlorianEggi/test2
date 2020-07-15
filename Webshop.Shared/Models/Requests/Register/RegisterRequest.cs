using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.Register
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string mail { get; set; }

        [Required]
        [MaxLength(20)]
        public string password { get; set; }

      
    }
}
