using MyHome.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class AuctionDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }

        public string Name { get; set; }
        // Additional properties for Auction here

    }
}
