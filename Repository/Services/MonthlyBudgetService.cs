using System.Collections.Generic;
using Models.Models;
using Repository.Repository;

namespace Repository.Services
{
    public class MonthlyBudgetService
    {
        private readonly MonthlyBudgetRepository _monthlyBudgetRepository = new MonthlyBudgetRepository();

        public MonthlyBudget Get(int year, int month)
        {
            var monthlyBudget = _monthlyBudgetRepository.Get(year, month);
            monthlyBudget?.MarkOld();

            return monthlyBudget;
        }

        public List<MonthlyBudget> GetAll()
        {
            var monthlyBudgets = _monthlyBudgetRepository.GetAll();
            monthlyBudgets.ForEach(mb => mb.MarkOld());

            return monthlyBudgets;
        }

        public void Add(MonthlyBudget monthlyBudget)
        {
            _monthlyBudgetRepository.Add(monthlyBudget);
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