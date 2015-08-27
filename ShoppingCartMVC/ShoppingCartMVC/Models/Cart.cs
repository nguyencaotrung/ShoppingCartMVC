﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartMVC.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string SessionId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}