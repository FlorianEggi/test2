using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.ArticleDetails
{
    public class ArticleDetailResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ArticleData Data { get; set; }
    }
}
