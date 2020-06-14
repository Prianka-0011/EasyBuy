using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.ViewModels
{
    public class CartItemVm
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
       
        public string Name { get; set; }
    
        public decimal Price { get; set; }
       
        public decimal PrevPrice { get; set; }
        public int Quentity { get; set; }
        public string Image { get; set; }
        //Nvigation Prop
        public string Category { get; set; }
    }
}
