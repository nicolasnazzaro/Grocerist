using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}