using System.Collections.Generic;
using Models.Models;
using Repository.Repository;

namespace Repository.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Add(string name, string color)
        {
            _categoryRepository.Add(name, color);
        }

        public void Edit(Category category)
        {
            _categoryRepository.Edit(category);
        }
    }
}