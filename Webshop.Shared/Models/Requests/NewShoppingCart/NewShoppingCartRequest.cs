using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.NewShoppingCart
{
    public class NewShoppingCartRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        public string commissionid { get; set; }
    }
}
