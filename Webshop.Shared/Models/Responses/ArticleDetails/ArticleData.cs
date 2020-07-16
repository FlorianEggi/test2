using Newtonsoft.Json;
using System.Collections.Generic;

namespace Webshop.Shared.Models.Responses.ArticleDetails
{
    public class ArticleData
    {
        [JsonProperty("itemid")]

        public string Itemid { get; set; }

        [JsonProperty("datanormname1")]

        public string Datanormname1 { get; set; }

        [JsonProperty("datanormname2")]

        public string Datanormname2 { get; set; }

        [JsonProperty("unit")]

        public string Unit { get; set; }

        [JsonProperty("grossprice")]

        public string Grossprice { get; set; }

        [JsonProperty("netprice")]

        public string Netprice { get; set; }

        [JsonProperty("customernetprice")]

        public string Customernetprice { get; set; }

        [JsonProperty("vatrate")]

        public string Vatrate { get; set; }

        [JsonProperty("pictures")]

        public List<Picture> Pictures { get; set; }

        [JsonProperty("packaging")]

        public List<Packaging> Packaging { get; set; }

        [JsonProperty("discount")]

        public List<Discount> Discount { get; set; }

        [JsonProperty("discountgroup")]

        public string Discountgroup { get; set; }

        [JsonProperty("discountgroupname")]

        public string Discountgroupname { get; set; }

        [JsonProperty("encrypted")]

        public Encrypted Encrypted { get; set; }

    }
}