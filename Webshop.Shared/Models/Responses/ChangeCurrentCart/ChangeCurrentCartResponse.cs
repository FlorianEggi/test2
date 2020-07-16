using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Webshop.Shared.Models.Responses.ArticleDetails;

namespace Webshop.Shared.Models.Responses.ChangeCurrentCart
{
    public class ChangeCurrentCartResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ArticleData Data { get; set; }


    }
}
