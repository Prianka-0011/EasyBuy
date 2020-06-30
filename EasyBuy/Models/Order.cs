using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int OrderNo { get; set; }
        //Navigation Prop
        public int Quentity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
