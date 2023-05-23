using MyHome.Domain;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class PhotoDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        [JsonIgnore]
        public string UploadedBy { get; set; }
        [JsonIgnore]
        public DateTime UploadedOn { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }
    }
}