using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Setting
    {
        public Setting()
        {
            Categories = new HashSet<Category>();
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
            Transactions = new HashSet<Transaction>();
            Users = new HashSet<User>();
            Vouchers = new HashSet<Voucher>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
