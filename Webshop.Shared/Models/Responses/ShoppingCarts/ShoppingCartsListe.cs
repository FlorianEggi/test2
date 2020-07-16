using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.ShoppingCarts
{
    public class ShoppingCartsListe
    {
        [JsonProperty("cartid")]

        public string Cartid { get; set; }

        [JsonProperty("comissionid")]

        public string Comissionid { get; set; }

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

        [JsonProperty("cartitemscount")]
        public string Cartitemscount { get; set; }
    }
}