using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
            ProductVariants = new HashSet<ProductVariant>();
        }

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string? PrimaryImage { get; set; }
        public int? Status { get; set; }

        public virtual Setting? StatusNavigation { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
