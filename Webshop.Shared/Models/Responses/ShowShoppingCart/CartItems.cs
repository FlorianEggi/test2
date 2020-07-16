using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.ShowShoppingCart
{
    public class CartItems
    {
        [JsonProperty("cartposition")]

        public string Cartposition { get; set; }

        [JsonProperty("itemid")]

        public string Itemid { get; set; }

        [JsonProperty("datanormname1")]
        public string Datanormname1 { get; set; }

        [JsonProperty("datanormname2")]
        public string Datanormname2 { get; set; }

        [JsonProperty("cartamount")]
        public string Cartamount { get; set; }

       

    }
}