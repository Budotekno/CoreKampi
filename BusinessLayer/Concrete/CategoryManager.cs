using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICateroryDal _cateroryDal;
        public CategoryManager(ICateroryDal cateroryDal)
        {
            _cateroryDal = cateroryDal;
        }


        public void AddCategory(Category p)
        {
            _cateroryDal.Insert(p);
        }

        public void DeleteCategory(Category p)
        {
            _cateroryDal.Delete(p);
        }

        public Category GetById(int id)
        {
            return _cateroryDal.GetById(id);
        }

        public List<Category> ListAllCategory()
        {
            return _cateroryDal.ListAll();
        }

        public void UpdateCategory(Category p)
        {
            _cateroryDal.Update(p);
        }
    }
}
