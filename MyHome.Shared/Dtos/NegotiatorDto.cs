using MyHome.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class NegotiatorDto
    {
        [JsonIgnore]
        public int NegotiatorId { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }
        [MaxLength(256)]
        public string? Name { get; set; }
        [MaxLength(256)]
        public string? Phone { get; set; }

        [MaxLength(256)]
        public string? Email { get; set; }

        [MaxLength(256)]
        public string? WebSite { get; set; }
    }

}
