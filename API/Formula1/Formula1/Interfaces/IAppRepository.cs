﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Interfaces
{
    public interface IAppRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);

        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);



    }
}
