﻿using System;
using System.Text.Json.Serialization;
using Core.Signatures;

namespace Entities.Concrete
{
    public class Appointment : IBaseEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public bool IsActive { get; set; } = true;
        
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        public DateTime Date { get; set; }
        
        [JsonIgnore]
        public Doctor Doctor { get; set; }
        [JsonIgnore]
        public Patient Patient { get; set; }
    }
}