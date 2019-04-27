using System;

namespace Models.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public decimal Value { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public DateTime ModificationTime { get; set; }
    }
}