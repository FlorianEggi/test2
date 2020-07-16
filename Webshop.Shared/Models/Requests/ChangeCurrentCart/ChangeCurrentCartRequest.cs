using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.ChangeCurrentCart
{
    public class ChangeCurrentCartRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        public string cartid { get; set; }
    }
}
