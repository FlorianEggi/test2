using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.ShowShoppingCart
{
    public class ShowShoppingCartResponse
    {
        [JsonProperty(PropertyName = "status")]

        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ShowShoppingCartData Data { get; set; }

    }
}
