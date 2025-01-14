﻿using System;
using Core.Signatures;
using Newtonsoft.Json;

namespace Entities.Concrete
{
    public class PersonLoginHistory : IBaseEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }

        [JsonIgnore]
        public Person Person { get; set; }public string IpAddress { get; set; }
    }
}