using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}