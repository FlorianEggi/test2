using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses
{
    public class Data

    {
        [JsonProperty("sessionid")]

        public string Sessionid { get; set; }

        [JsonProperty("username")]

        public string Username { get; set; }
    }
}
