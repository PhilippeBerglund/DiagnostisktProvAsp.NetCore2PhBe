using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Range(5, 1000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public decimal Price { get; set; }

        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}
