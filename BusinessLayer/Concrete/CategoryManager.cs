using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>, ICategorService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void DeleteT(Category entity)
        {
            _categoryDal.Delete(entity);

        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public IQueryable<Category> GetListAll()
        {
            return _categoryDal.GetListAll();

        }

        public void InsertT(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void UpdateT(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
