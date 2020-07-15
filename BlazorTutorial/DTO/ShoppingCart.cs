using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.DTO
{
    public class ShoppingCart
    {
        public string ShoppingCartName { get; set; }
        public List<Product> Products { get; set; }
    }
}
