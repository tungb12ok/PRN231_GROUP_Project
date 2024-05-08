using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string? PathImage { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
