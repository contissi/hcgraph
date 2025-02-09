﻿using System.ComponentModel.DataAnnotations;

namespace hcgraph.Domain.Models
{
    public class OrderItem : BaseModel
    {
        [Required]
        public long OrderId { get; set; }

        [Required]
        public long ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }

        public virtual Item? Item { get; set; }
    }
}
