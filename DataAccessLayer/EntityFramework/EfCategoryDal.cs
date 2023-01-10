using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepositoryDal<Category>,ICategoryDal
    {
    }
}