using MyHome.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class AdditionalLogoDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }
        public string Url { get; set; }

    }
}
