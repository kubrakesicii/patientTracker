﻿using System.Text.Json.Serialization;
using Core.Signatures;

namespace Entities.Concrete
{
    public class Department : IBaseEntity
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        [JsonIgnore]
        public Hospital Hospital { get; set; }
    }
}