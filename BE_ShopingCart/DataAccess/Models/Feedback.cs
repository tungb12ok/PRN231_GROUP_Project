using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string? Comment { get; set; }
        public int? Rate { get; set; }
        public DateTime? Time { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
