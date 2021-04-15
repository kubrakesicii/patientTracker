﻿using System;

namespace Web.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
 
    }
}