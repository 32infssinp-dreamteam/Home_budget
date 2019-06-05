using System.Collections.Generic;
using Models.Models;
using Repository.Services;

namespace Services.BusinessServices
{
    public class MonthlyBudgetsBusinessService
    {
        private readonly MonthlyBudgetService _monthlyBudgetService = new MonthlyBudgetService();

        public void SaveChanges(List<MonthlyBudget> monthlyBudgets)
        {
            monthlyBudgets.ForEach(budget =>
            {
                if (budget.IsNew)
                {
                    _monthlyBudgetService.Add(budget);
                }
                else if (budget.IsDeleted)
                {
                    _monthlyBudgetService.Delete(budget);
                }
                else if (budget.IsDirty)
                {
                    _monthlyBudgetService.Edit(budget);
                }
            });
        }
    }
}