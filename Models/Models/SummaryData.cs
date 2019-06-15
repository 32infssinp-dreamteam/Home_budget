using System;
using System.Drawing;

namespace Models.Models
{
    public class SummaryData
    {
        public DateTime Date { get; set; }

        public string DateStr { get; set; }

        public decimal Value { get; set; }

        public long CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Color CategoryColor { get; set; }
    }
}