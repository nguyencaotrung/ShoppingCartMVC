using Newtonsoft.Json;

namespace ShoppingCartMVC.Models.ViewModel
{
    class CategoryViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
