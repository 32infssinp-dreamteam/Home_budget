using System;
using System.Collections.Generic;
using Models.Models;
using Repository.Repository;

namespace Repository.Services
{
    public class ExpenseService
    {
        private readonly ExpenseRepository _expenseRepository = new ExpenseRepository();

        public Expense GetById(int id)
        {
            var expense = _expenseRepository.GetById(id);
            expense.MarkOld();

            return expense;
        }

        public List<Expense> GetByDate(DateTime date)
        {
            var expenses = _expenseRepository.GetByDate(date);
            expenses.ForEach(expense =>
            {
                expense.MarkOld();
            });

            return expenses;
        }

        public List<Expense> GetByMonth(int year, int month)
        {
            var expenses = _expenseRepository.GetByMonth(year, month);
            expenses.ForEach(expense =>
            {
                expense.MarkOld();
            });

            return expenses;
        }

        public void Add(Expense expense)
        {
            _expenseRepository.Add(expense);

            expense.MarkOld();
        }

        public void Edit(Expense expense)
        {
            _expenseRepository.Edit(expense);
        }

        public void Delete(Expense expense)
        {
            _expenseRepository.Delete(expense);
        }
    }
}