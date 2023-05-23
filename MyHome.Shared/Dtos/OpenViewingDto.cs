﻿using MyHome.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyHome.Shared.Dtos
{
    public class OpenViewingDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PropertyId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
