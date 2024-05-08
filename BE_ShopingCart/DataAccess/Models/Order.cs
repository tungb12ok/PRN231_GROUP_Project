using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Status { get; set; }

        public virtual Setting? StatusNavigation { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
