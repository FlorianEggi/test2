using Newtonsoft.Json;
using System.Collections.Generic;

namespace Webshop.Shared.Models.Responses.ShoppingCarts
{
    public class ShoppingCartData
    {
        [JsonProperty("carts")]

        public List<ShoppingCartsListe> Carts { get; set; }

    }
}