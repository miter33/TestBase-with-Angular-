using System.Linq;
using TestBase.Common.Entities;

namespace TestBase.DAL.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAll();

        Category GetById(int id);
        void Add(Category category);
    }
}
