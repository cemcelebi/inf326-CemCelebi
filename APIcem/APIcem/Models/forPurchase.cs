using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIcem.Models
{
    public class ProductforPurchase
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        
        public int Price { get; set; }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
       
        public int PurchaseId { get; set; }


    }
}