﻿using System.ComponentModel.DataAnnotations;

namespace Nation1.Models
{
    public class WishItem
    {
        [Key]
        public string ItemId { get; set; }

        public string WishId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}