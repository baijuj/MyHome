using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyHome.Domain
{
    public class RelatedPropertyID
    {
        [Key]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int CustomDataId { get; set; }
        public virtual CustomData CustomData { get; set; }
    }
}