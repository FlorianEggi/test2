using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.ShoppingCarts
{
    public class ShoppingCartResponse
    {
        [JsonProperty(PropertyName = "status")]

        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ShoppingCartData Data { get; set; }
    }
}
