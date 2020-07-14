using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Shared.Models.Responses
{
   public class RegisterResponse
    {
        [JsonProperty(PropertyName="status")]

        public string Status { get; set; }

        [JsonProperty(PropertyName="data")]
        public List<Data> Data { get; set; }
       // public string[] Error { get; set; }

    }
}
