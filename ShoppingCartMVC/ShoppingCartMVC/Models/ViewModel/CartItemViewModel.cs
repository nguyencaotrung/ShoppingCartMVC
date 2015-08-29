using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ShoppingCartMVC.Models.ViewModel
{
    class CartItemViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "cartID")]
        public int CartID { get; set; }

        [JsonProperty(PropertyName = "productID")]
        public int ProductID { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "product")]
        public ProductViewModel Book { get; set; }
    }
}
