﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace APIcem.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Cartproducts { get; set; }
        public decimal TotalPrice { get; set; }
    }
}