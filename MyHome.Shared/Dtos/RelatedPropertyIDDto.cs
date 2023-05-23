using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class RelatedPropertyIDDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int CustomDataId { get; set; }
    }
}