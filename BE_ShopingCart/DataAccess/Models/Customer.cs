using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }

        public virtual User CustomerNavigation { get; set; } = null!;
    }
}
