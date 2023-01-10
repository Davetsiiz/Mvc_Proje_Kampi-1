using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Blog.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManagerBl cm=new CategoryManagerBl(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            //var categoryvalues=cm.GetListBl();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p) 
        { 
            //cm.CategoryAddBl(p);
            CategoryValidator categoryValidator= new CategoryValidator();
            ValidationResult results=categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBl(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}