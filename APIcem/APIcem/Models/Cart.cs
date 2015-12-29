using System;
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
        public Decimal TotalPrice { get; set; }
        public DateTime dateOfCreation { get; set; }
        public virtual ICollection<inCart> Productslist { get; set; }
    }
}