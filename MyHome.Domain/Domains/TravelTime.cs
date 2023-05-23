using System.ComponentModel.DataAnnotations.Schema;

namespace MyHome.Domain
{
    public class TravelTime
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }

        // Additional properties for TravelTime here

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
