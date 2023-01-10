﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T>
    {

        //CRUD
        //Type Name();
        List<T> listDal();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> list(Expression<Func<T, bool>> filter);
        
        T Get(Expression<Func<T, bool>> filter);

    }
}
