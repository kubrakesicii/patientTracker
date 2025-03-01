﻿using System;

namespace Entities.Dtos
{
    public class GetAnswerDto
    {
        public string QuestionDesc { get; set; }
        public int UpperLimit { get; set; }
        public int LowerLimit { get; set; }
        public string AnswerDesc { get; set; }
        public decimal PatientScore { get; set; }
        public bool Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}