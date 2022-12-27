using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DataAccessLayer.Concrete
{
    public class GenericRepositoryDal<T> : IRepositoryDal<T> where T : class
    {
        Context db = new Context();//sql bağlantı

        DbSet<T> _object; //obje tanımlamak için 

        public GenericRepositoryDal()
        {
            _object = db.Set<T>(); //deger atama
        }

        //ctorr tabtab


        public void Delete(T t)
        {
            _object.Remove(t);
            db.SaveChanges();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            db.SaveChanges();
        }

        public List<T> listDal()
        {
            return _object.ToList();
        }

        public List<T> list(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {

            db.SaveChanges();
        }
    }
}