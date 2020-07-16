using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.AddItemToCart
{
    public class AddItemToCartRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        public string cartid { get; set; }

        public string itemid { get; set; }

        public string orderamount { get; set; }
    }
}
