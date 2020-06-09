using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quentity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
