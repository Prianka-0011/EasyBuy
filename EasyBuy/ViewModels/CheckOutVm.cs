using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.ViewModels
{
    public class CheckOutVm
    {
        //Product info
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public decimal PrevPrice { get; set; }
        public decimal Quentity { get; set; }
        public string Image { get; set; }
        //Nvigation Prop
        public string Category { get; set; }
        //customer Info
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int OrderNo { get; set; }
    }
}
