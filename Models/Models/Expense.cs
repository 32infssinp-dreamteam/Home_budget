using System;
using System.Drawing;

namespace Models.Models
{
    public class Expense : BusinessEntity
    {
        public long CategoryId { get; set; }

        private string _categoryName;
        public string CategoryName
        {
            get => _categoryName;
            set
            {
                if (_categoryName != value)
                {
                    _categoryName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Color _categoryColor;
        public Color CategoryColor
        {
            get => _categoryColor;
            set
            {
                if (_categoryColor != value)
                {
                    _categoryColor = value;
                    NotifyPropertyChanged();
                }
            }
        }

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