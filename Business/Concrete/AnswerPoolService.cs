﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Repositories;
using Business.Validations;
using Core.Aspects.Security;
using Core.Aspects.Validation;
using Core.Enums;
using DataAccess.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    [SecurityAspect(PersonType.Doctor)]
    [ValidationAspect(typeof(AnswerValidator))]
    public class AnswerPoolService : ServiceRepository<AnswerPool>, IAnswerPoolService
    {
        private readonly IRepository<AnswerPool> _repository;
        
        public AnswerPoolService(IRepository<AnswerPool> repository) : base(repository)
        {
            _repository = repository;
        }

        [SecurityAspect(PersonType.Doctor)]
        public async Task<List<AnswerPool>> GetAnswersOfQuestion(int questionId)
        {
            return await _repository.GetAllAsync(x => x.QuestionPoolId == questionId);
        }
        
        
    }
}