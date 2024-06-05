using System.Text.Json.Serialization;


namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int CategoriesId { get; set; }

        [JsonIgnore]
        public Categories? Categories { get; set; }
        private OrderDetails? OrderDetails { get; set; }

    }
}
