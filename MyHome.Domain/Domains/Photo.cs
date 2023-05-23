using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyHome.Domain
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoURL { get; set; }
        public string? UploadedBy { get; set; }
        public DateTime UploadedOn { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}