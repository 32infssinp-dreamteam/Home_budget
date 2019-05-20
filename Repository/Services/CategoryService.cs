using System.Collections.Generic;
using System.Drawing;
using Models.Models;
using Repository.Repository;

namespace Repository.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public List<Category> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            categories.ForEach(category =>
            {
                category.Color = ColorTranslator.FromHtml(category.ColorText);

                category.MarkOld();
            });

            return categories;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);

            category.MarkOld();
        }

        public void Edit(Category category)
        {
            _categoryRepository.Edit(category);

            category.MarkOld();
        }
    }
}