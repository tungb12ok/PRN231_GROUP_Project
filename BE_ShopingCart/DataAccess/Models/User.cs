﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
            Transactions = new HashSet<Transaction>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public int? RoleId { get; set; }
        public int? Status { get; set; }

        public virtual Role? Role { get; set; }
        public virtual Setting? StatusNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
