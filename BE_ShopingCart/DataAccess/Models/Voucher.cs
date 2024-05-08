using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Voucher
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public DateTime? Expired { get; set; }
        public int Status { get; set; }

        public virtual Setting StatusNavigation { get; set; } = null!;
    }
}
