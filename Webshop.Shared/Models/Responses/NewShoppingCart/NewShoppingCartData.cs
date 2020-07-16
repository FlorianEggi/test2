using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.NewShoppingCart
{
    public class NewShoppingCartData
    {
        [JsonProperty("cartid")]

        public string Cartid { get; set; }

    }
}