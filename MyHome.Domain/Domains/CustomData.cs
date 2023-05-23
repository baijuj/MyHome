using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyHome.Domain
{
    public class CustomData
    {
        [Key]
        public int Id { get; set; }
        public int PropertyId { get; set; }
 
        public virtual Property Property { get; set; }
        public ICollection<RelatedPropertyID> RelatedPropertyIDs { get; set; }

        public bool IsMyHomePassport { get; set; }
        public string? PromotionalSnippet { get; set; }
        public string? DevelopmentLogoBgColour { get; set; }
    }
}