using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }

        public virtual Setting? StatusNavigation { get; set; }
    }
}
