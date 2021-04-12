﻿using Entities.Abstract;
using System;
using System.Collections.Generic;                        //Generic Repository Desing pattern kullanıldı
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>  where T:class,IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
    }
}
