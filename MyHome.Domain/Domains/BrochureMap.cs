using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyHome.Domain
{
    public class BrochureMap
    {
        [Key]
        public int Id { get; set; }
        public int PropertyId { get; set; }

        public virtual Property Property { get; set; }

        public double longitude { get; set; }

        public double latitude { get; set; }
    }

}
