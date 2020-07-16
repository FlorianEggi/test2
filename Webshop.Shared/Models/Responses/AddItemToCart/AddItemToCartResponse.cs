using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.AddItemToCart
{
    public class AddItemToCartResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public AddItemToCartData Data { get; set; }
    }
}
