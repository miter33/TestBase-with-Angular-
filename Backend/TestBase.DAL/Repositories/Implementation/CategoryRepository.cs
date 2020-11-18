using System.Collections.Generic;
using System.Linq;
using TestBase.Common.Entities;
using TestBase.DAL.Context;
using TestBase.DAL.Repositories.Interfaces;

namespace TestBase.DAL.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TestBaseContext context;

        public CategoryRepository(TestBaseContext context)
        {
            this.context = context;
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category GetById(int id)
        {
            return context.Categories.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Category category)
        {
            context.Add(category);
            context.SaveChanges();
        }
    }
}
