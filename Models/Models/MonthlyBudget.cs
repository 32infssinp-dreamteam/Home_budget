namespace Models.Models
{
    public class MonthlyBudget
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public decimal BudgetValue { get; set; }
    }
}