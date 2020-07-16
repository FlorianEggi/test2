using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.ChangeCurrentCart
{
    public class ChangeCurrentCartData
    {

        [JsonProperty(PropertyName = "cartid")]
        public string Cartid { get; set; }
    }
}
