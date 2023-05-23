using System.ComponentModel.DataAnnotations.Schema;

namespace MyHome.Domain
{
    public class AdditionalLogo
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string Url { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
