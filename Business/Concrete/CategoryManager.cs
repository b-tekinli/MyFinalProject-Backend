﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // İş Kodları
            return _categoryDal.GetAll();
        }

        List<Category> ICategoryService.GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
