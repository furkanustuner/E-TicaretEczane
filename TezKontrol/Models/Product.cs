using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TezKontrol.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }

        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsStock { get; set; }
        public int CategoryId { get; set; }
        [foreignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
