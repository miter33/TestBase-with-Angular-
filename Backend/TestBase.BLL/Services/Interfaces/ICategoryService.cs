using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestBase.Common.Entities;

namespace TestBase.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAll();

        Category GetById(int id);

        void Add(Category category);
    }
}
