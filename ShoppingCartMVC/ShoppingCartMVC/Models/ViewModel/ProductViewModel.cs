using Newtonsoft.Json;

namespace ShoppingCartMVC.Models.ViewModel
{
    public class ProductViewModel
    {
        [JsonProperty(PropertyName = "productID")]
        public int ProductID { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty(PropertyName = "longDescription")]
        public string longdescription { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal price { get; set; }

        [JsonProperty(PropertyName = "category")]
        public virtual CategoryViewModel Category { get; set; }
    }
}