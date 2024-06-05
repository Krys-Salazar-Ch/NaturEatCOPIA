using System.Text.Json.Serialization;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string eMail { get; set; }
        public int Phone_Number { get; set; }

        [JsonIgnore]
        public List<Order_Confirmation>? Order_Confirmation { get; set; }
    }
}
