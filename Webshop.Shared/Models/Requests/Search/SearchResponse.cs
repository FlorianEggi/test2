using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.Search
{
    public class SearchResponse
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        public bool codestockitems { get; set; }

        [StringLength(60)]

        public string searchterms { get; set; }

        public int displaycount { get; set; }
    }
}
