using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public string Quantity { get; set; }
    }
}
