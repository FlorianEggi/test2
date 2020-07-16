using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.ShoppingCarts
{
    public class ShoppingCartRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }
    }
}
