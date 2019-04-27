using Models.Models;
using Repository.Repository;

namespace Repository.Services
{
    public class MonthlyBudgetService
    {
        private readonly MonthlyBudgetRepository _monthlyBudgetRepository = new MonthlyBudgetRepository();

        public MonthlyBudget Get(int year, int month)
        {
            return _monthlyBudgetRepository.Get(year, month);
        }

        public void Add(int year, int month, decimal budgetValue)
        {
            _monthlyBudgetRepository.Add(year, month, budgetValue);
        }

        public void Edit(MonthlyBudget monthlyBudget)
        {
            _monthlyBudgetRepository.Edit(monthlyBudget);
        }

        public void Delete(MonthlyBudget monthlyBudget)
        {
            _monthlyBudgetRepository.Delete(monthlyBudget);
        }
    }
}