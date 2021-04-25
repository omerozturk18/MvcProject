﻿using DataAccessLibrary.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> _genericRepository;

        public CategoryManager(GenericRepository<Category> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public List<Category> GetAll()
        {
            return _genericRepository.GetAll();
        }
        public void AddCategory(Category category)
        {
            if (category.CategoryName==""||category.CategoryName.Length<=3||category.CategoryDescription==""||category.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            _genericRepository.Add(category);
        }
    }
}