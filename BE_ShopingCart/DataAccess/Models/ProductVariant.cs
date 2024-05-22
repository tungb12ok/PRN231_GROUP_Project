using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProductVariant
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Size { get; set; } = null!;
        public string? Color { get; set; }
        public int? Quantity { get; set; }
        public bool? Lock { get; set; }

        public virtual Product? Product { get; set; }
    }
}
