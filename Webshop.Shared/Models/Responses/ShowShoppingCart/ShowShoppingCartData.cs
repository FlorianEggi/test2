using Newtonsoft.Json;
using System.Collections.Generic;

namespace Webshop.Shared.Models.Responses.ShowShoppingCart
{
    public class ShowShoppingCartData
    {
        [JsonProperty("cartid")]

        public string Cartid { get; set; }

        [JsonProperty("commissionid")]

        public string Commissionid { get; set; }

        [JsonProperty("deliveryaddress1")]
        public string Deliveryaddress1 { get; set; }

        [JsonProperty("deliveryaddress2")]
        public string Deliveryaddress2 { get; set; }

        [JsonProperty("deliveryzip")]

        public string Deliveryzip { get; set; }

        [JsonProperty("deliverycity")]

        public string Deliverycity { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("cartitems")]
        public List<CartItems> Cartitems { get; set; }

    }
}