using System.Collections.Generic;
using System.Linq;
using Models.Models;
using Repository.Services;

namespace Services.BusinessServices
{
    public class CategoryBusinessService
    {
        private readonly CategoryService _categoryService = new CategoryService();

        public void SaveChanges(List<Category> categories)
        {
            categories.ForEach(cat =>
            {
                if (cat.IsNew)
                {
                    _categoryService.Add(cat);
                }
                else if (cat.IsDeleted)
                {
                    _categoryService.Delete(cat);
                }
                else if (cat.IsDirty)
                {
                    _categoryService.Edit(cat);
                }
            });
        }
    }
}