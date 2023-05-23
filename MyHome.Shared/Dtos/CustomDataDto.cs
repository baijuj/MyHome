using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MyHome.Domain;

namespace MyHome.Shared.Dtos
{
    public class CustomDataDto
    {

        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }
        public ICollection<RelatedPropertyID> RelatedPropertyIDs { get; set; }
        public bool IsMyHomePassport { get; set; }
        public string? PromotionalSnippet { get; set; }
        public string? DevelopmentLogoBgColour { get; set; }
    }
}