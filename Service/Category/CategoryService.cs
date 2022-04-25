using Core.Data;
using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<int> CreateNewCategory(Category category)
        {
            var userFromBD = await GetCategoryByCategoryName(category.CategoryName);
            if (!(userFromBD != null))
                await _unitOfWork.CategoryRepository.AddAsync(category);

            return await _unitOfWork.CommitAsync();
        }
        public async Task<Category> GetCategoryByCategoryName(string catName)
        {
            var cat = await _unitOfWork.CategoryRepository.FirstOrDefault(u => u.CategoryName.Equals(catName));
            return cat;
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            var cat = await _unitOfWork.CategoryRepository.GetAllAsync();
            return cat;
        }
    }
}
