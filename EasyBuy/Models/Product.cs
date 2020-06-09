using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal PrevPrice { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public bool IsAviable { get; set; }
        //Nvigation Prop
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
