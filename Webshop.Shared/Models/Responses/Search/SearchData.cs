using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.Search
{
    public class SearchData
    {
        [JsonProperty("displaycount")]

        public string Displaycount { get; set; }

        [JsonProperty("itemscount")]

        public string Itemscount { get; set; }
        
        [JsonProperty("itemidfirst")]
        public string Itemidfirst { get; set; }

        [JsonProperty("itemidlist")]
        public string Itemidlist { get; set; }

        [JsonProperty("searchresults")]
        public List<SearchResults> Searchresults { get; set; }
    }
}
