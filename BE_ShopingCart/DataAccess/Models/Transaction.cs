using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime? Date { get; set; }
        public int UserId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Type { get; set; }
        public int Status { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Setting StatusNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
