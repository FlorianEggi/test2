using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.ArticleDetails
{
    public class Picture
    {
        [JsonProperty("imagetype")]

        public string Imagetype { get; set; }

        [JsonProperty("fullsizepath")]

        public string Fullsizepath { get; set; }

        [JsonProperty("previewpath")]

        public string Previewpath { get; set; }
    }
}