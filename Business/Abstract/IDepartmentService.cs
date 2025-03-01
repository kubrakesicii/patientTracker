﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Repositories;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IDepartmentService : IServiceRepository<Department>
    {
        //Task<List<Department>> GetAllByHospAsync(int hospitalId);
        Task<List<Department>> GetAllAsync(int hospitalId);


        Task<int> CountAsync(int hospitalId);
    }
}