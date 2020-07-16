using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webshop.Shared.Models.Requests.ArticleDetails
{
   public class ArticleDetailRequest
    {
        [StringLength(60)]
        public string sessionid { get; set; }

        [StringLength(13)]
        public string ean { get; set; }

        [StringLength(15)]
        public string itemid { get; set; }

        [StringLength(15)]
        public string customeritemid { get; set; }
    }
}
