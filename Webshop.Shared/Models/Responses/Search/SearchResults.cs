using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.Search
{
    public class SearchResults
    {
        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("datanormname1")]
        public string Datanormname1 { get; set; }


        [JsonProperty("datanormname2")]
        public string Datanormname2 { get; set; }


        [JsonProperty("codestockitem")]
        public string Codestockitem { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("grossprice")]
        public int Grossprice { get; set; }

        [JsonProperty("discountgroup")]
        public string Discountgroup { get; set; }

      

    }
}
