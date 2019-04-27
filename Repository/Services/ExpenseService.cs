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
            return _expenseRepository.GetById(id);
        }

        public List<Expense> GetByDate(DateTime date)
        {
            return _expenseRepository.GetByDate(date);
        }

        public List<Expense> GetByMonth(int year, int month)
        {
            return _expenseRepository.GetByMonth(year, month);
        }

        public void Add(Expense expense)
        {
            _expenseRepository.Add(expense);
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