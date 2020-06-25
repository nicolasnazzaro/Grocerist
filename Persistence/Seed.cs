using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context) 
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product
                    {
                        ProductName = "Tomato",
                        ProductCategory = "Fruit & Vegetables",
                        ProductPrice = 0.80m,
                        ProductDescription = ""
                    },
                    new Product
                    {
                        ProductName = "Spinach",
                        ProductCategory = "Fruit & Vegetables",
                        ProductPrice = 0.90m,
                        ProductDescription = ""
                    },
                    new Product
                    {
                        ProductName = "Mixed Salad",
                        ProductCategory = "Fruit & Vegetables",
                        ProductPrice = 1.80m,
                        ProductDescription = ""
                    },
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}