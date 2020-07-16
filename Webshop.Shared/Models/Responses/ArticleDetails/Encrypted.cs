using Newtonsoft.Json;

namespace Webshop.Shared.Models.Responses.ArticleDetails
{
    public class Encrypted
    {
        [JsonProperty("itemid")]

        public string Itemid { get; set; }

        [JsonProperty("datanormname1")]

        public string Datanormname1 { get; set; }

        [JsonProperty("datanormname2")]

        public string Datanormname2 { get; set; }
    }
}