using System.Text.Json.Serialization;


namespace Entities
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Product>? Products { get; set; }
    }
}

