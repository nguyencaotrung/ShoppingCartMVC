using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShoppingCartMVC.Models.ViewModel
{
    public class CartViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "cartItems")]
        public virtual ICollection<CartItemViewModel> CartItems { get; set; }
    }
}