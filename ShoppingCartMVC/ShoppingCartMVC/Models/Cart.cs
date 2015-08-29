using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ShoppingCartMVC.Models
{
    public class Cart
    {
        public int ID { get; set; }

        [Index(IsUnique = true)]
        [StringLength(255)]
        public string SessionID { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}