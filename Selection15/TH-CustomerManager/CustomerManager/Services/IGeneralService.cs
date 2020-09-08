﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services
{
    public interface IGeneralService<T> where T : class

    {

        Task<List<T>> GetAll();

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Get(int id);

        Task<T> Delete(int id);

    }
}
