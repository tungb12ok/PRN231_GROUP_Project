﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public string? PathImage { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}
