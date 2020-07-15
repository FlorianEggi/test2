using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses.Register
{
    public class RegisterData

    {
        [JsonProperty("sessionid")]

        public string Sessionid { get; set; }

        [JsonProperty("username")]

        public string Username { get; set; }
    }
}
