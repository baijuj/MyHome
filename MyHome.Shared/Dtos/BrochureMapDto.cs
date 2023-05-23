using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyHome.Domain;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class BrochureMapDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }

        public double longitude { get; set; }

        public double latitude { get; set; }
    }

}
