using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICategoryService
    {
        Task<int> CreateNewCategory(Category category);
        Task<Category> GetCategoryByCategoryName(string catName);
        Task<IEnumerable<Category>> GetAll();

    }
}
