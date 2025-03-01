﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Repositories;
using Core.Models;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICountryService : IServiceRepository<Country>
    {
         Task<List<Country>> GetAllAsync();

         Task<List<TreeList>> SelectListAsync();

         Task<int> CountAsync();
    }
}