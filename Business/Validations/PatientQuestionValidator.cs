﻿using Entities.Concrete;
using FluentValidation;

namespace Business.Validations
{
    public class PatientQuestionValidator : AbstractValidator<PatientQuestion>
    {
        public PatientQuestionValidator()
        {
            RuleFor(x => x.PatientId).NotEmpty().NotNull();
            RuleFor(x => x.QuestionPoolId).NotEmpty().NotNull();
        }
    }
}