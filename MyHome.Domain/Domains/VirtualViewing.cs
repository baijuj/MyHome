using System.ComponentModel.DataAnnotations.Schema;

namespace MyHome.Domain
{
    public class VirtualViewing
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
