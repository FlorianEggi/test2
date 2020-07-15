using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.NewShoppingCart
{
   public class NewShoppingCartResponse
    {
        [JsonProperty(PropertyName = "status")]

        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public NewShoppingCartData Data { get; set; }

    }
}
