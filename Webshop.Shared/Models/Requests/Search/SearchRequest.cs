using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.Search
{
    public class SearchRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        [StringLength(5)]
        public string codestockitems { get; set; }

        [StringLength(60)]
        public string searchterms { get; set; }

        public string displaycount { get; set; }
    }
}
