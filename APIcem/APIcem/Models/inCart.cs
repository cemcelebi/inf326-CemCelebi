using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APIcem.Models
{

    public class inCart
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }


    }
}