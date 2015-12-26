using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIcem.Models
{
    public class APIcemContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public APIcemContext() : base("name=APIcemContext")
        {
        }

        public System.Data.Entity.DbSet<APIcem.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<APIcem.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<APIcem.Models.Purchase> Purchases { get; set; }

        public System.Data.Entity.DbSet<APIcem.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<APIcem.Models.CartDTO> CartDTOes { get; set; }
    
    }
}
