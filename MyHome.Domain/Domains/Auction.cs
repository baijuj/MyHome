using System.ComponentModel.DataAnnotations.Schema;

namespace MyHome.Domain
{
    public class Auction
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }

        // Additional properties for Auction here

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
    }
}
