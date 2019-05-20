using System;

namespace Models.Models
{
    public class Expense : BusinessEntity
    {
        public int CategoryId { get; set; }

        private decimal _value;
        public decimal Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                if (_date != value)
                {
                    _date = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private DateTime _modificationTime;
        public DateTime ModificationTime
        {
            get => _modificationTime;
            set
            {
                if (_modificationTime != value)
                {
                    _modificationTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}