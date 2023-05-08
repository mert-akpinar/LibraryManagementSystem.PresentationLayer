using LibraryManagementSystem.BusinessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.Abstract;
using LibraryManagementSystem.DataAccessLayer.EntityFramework;
using LibraryManagementSystem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }
        public Category TGetByID(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }
        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }
        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
