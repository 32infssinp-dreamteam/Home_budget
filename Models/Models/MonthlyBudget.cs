namespace Models.Models
{
    public class MonthlyBudget : BusinessEntity
    {
        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (_year != value)
                {
                    _year = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _month;
        public int Month
        {
            get => _month;
            set
            {
                if (_month != value)
                {
                    _month = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private decimal _budgetValue;
        public decimal BudgetValue
        {
            get => _budgetValue;
            set
            {
                if (_budgetValue != value)
                {
                    _budgetValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}