using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            if (context.Products.ToList().Count == 0)
            {
                var movieA = new Product { Name = "Harry Potter V", Price = 50 };
                var movieB = new Product { Name = "Spider Man ", Price = 60 };

                var catA = new ProductCategory { Name = "TV" };
                var catB = new ProductCategory { Name = "DVD" };
                var catC = new ProductCategory { Name = "VHS" };
                context.AddRange(movieA, movieB, catA, catB, catC);
                context.SaveChanges();
            }
        }
    }
}
