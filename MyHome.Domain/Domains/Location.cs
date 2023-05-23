using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyHome.Domain
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        public virtual Property Property { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }
    }

}
