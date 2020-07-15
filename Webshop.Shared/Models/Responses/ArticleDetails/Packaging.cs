using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.ArticleDetails
{
    public class Packaging
    {
        [JsonProperty("packagesize")]

        public string Packagesize { get; set; }
    }
}