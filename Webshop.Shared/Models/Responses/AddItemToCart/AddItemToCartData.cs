using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.AddItemToCart
{
    public class AddItemToCartData
    {
        [JsonProperty("cartid")]

        public string Cartid { get; set; }

    }
}