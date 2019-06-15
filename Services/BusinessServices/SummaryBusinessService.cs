using System.Collections.Generic;
using System.Linq;
using Models.Models;

namespace Services.BusinessServices
{
    public class SummaryBusinessService
    {
        public List<SummaryData> GroupDataByCategories(List<Expense> expenses)
        {
            var summaryData = expenses
                .GroupBy(expense => expense.CategoryId)
                .Select(gr => new SummaryData
                {
                    CategoryId = gr.Key,
                    CategoryName = gr.First().CategoryName,
                    CategoryColor = gr.First().CategoryColor,
                    Date = gr.First().Date,
                    DateStr = gr.First().Date.ToShortDateString(),
                    Value = gr.Sum(g => g.Value)
                })
                .ToList();

            return summaryData;
        }

        public List<SummaryData> GroupDataByDay(List<Expense> expenses)
        {
            var summaryData = expenses
                .GroupBy(expense => expense.Date)
                .Select(gr => new SummaryData
                {
                    Date = gr.Key,
                    CategoryId = gr.First().CategoryId,
                    CategoryName = gr.First().CategoryName,
                    CategoryColor = gr.First().CategoryColor,
                    DateStr = gr.First().Date.ToShortDateString(),
                    Value = gr.Sum(g => g.Value)
                })
                .ToList();

            return summaryData;
        }
    }
}