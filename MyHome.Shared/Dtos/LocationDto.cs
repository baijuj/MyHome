using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyHome.Domain;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class LocationDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }
    }

}
