using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string? PrimaryImage { get; set; }
        public int? Status { get; set; }

        public virtual Setting? StatusNavigation { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
