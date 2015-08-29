using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartMVC.Models
{
    public class Product
    {        
        public int ProductID { get; set; }       
        public string Title { get; set; }        
        public string ShortDescription { get; set; }       
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }       
        public double Price { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}