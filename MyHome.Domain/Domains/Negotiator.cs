using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyHome.Domain
{
    public class Negotiator
    {
        [Key]
        public int NegotiatorId { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
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
