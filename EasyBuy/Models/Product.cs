using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuy.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal PrevPrice { get; set; }
        [Required]
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
