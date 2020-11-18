using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestBase.BLL.Services.Interfaces;
using TestBase.Common.Entities;
using TestBase.DAL.Repositories.Interfaces;

namespace TestBase.BLL.Repositories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;
        public CategoryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public IQueryable<Category> GetAll()
        {
            return repository.GetAll();
        }

        public Category GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(Category category)
        {
            repository.Add(category);
        }
    }
}
