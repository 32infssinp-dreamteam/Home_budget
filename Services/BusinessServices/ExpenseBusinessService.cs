using System.Collections.Generic;
using System.Linq;
using Models.Models;
using Repository.Services;

namespace Services.BusinessServices
{
    public class ExpenseBusinessService
    {
        public void FillCategoryInfos(List<Expense> expenses, List<Category> categories)
        {
            expenses.ForEach(expense =>
            {
                var category = categories.First(cat => cat.Id == expense.CategoryId);
                expense.CategoryName = category.Name;
                expense.CategoryColor = category.Color;
            });
        }
    }
}