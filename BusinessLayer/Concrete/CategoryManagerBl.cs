using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer.Concrete
{
    public class CategoryManagerBl
    {
        //2. katmandaki DAL daki GenericRepository dekitanımlanan metotlara erişmek için bir nesne üretildi
        GenericRepositoryDal<Category> repo = new GenericRepositoryDal<Category>();

        public List<Category> GetListBl()
        {
            return repo.listDal();
        }
        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 50)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }

        }
    }
}