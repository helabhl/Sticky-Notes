using System;
using System.Collections.Generic;
using WindowsFormsApp1.Data.Entities;

namespace WindowsFormsApp1.Data.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        IEnumerable<Category> GetAll();
        Category GetById(int categoryId);
        bool Exists(int categoryId); 
    }
}