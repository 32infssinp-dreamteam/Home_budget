using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Models;
using Repository.Services;

namespace Home_budget.Views
{
    public partial class ExpenseEditView : Form
    {
        private List<Category> _categories;

        public Expense EditedExpense { get; set; }

        public ExpenseEditView(List<Category> categories, Expense editedExpense)
        {
            InitializeComponent();

            EditedExpense = editedExpense;
            _categories = categories;

            bsCategory.DataSource = _categories;
            bsCategory.ResetBindings(false);
        }

        private void ExpenseEditView_Load(object sender, EventArgs e)
        {
            if (EditedExpense.IsNew)
            {
                categoryComboBox.SelectedIndex = 0;
                datePicker.Value = DateTime.Today;
            }
            else
            {
                datePicker.Value = EditedExpense.Date;
                descriptionTextBox.Text = EditedExpense.Description;
                valueNumericUpDown.Value = EditedExpense.Value;
                categoryComboBox.SelectedItem = _categories.First(cat => cat.Id == EditedExpense.CategoryId);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value;
            EditedExpense.Date = date;
            EditedExpense.Year = date.Year;
            EditedExpense.Month = date.Month;
            EditedExpense.Day = date.Day;

            var value = valueNumericUpDown.Value;
            EditedExpense.Value = value;

            var category = (Category)categoryComboBox.SelectedItem;
            EditedExpense.CategoryId = category.Id;
            EditedExpense.CategoryName = category.Name;
            EditedExpense.CategoryColor = category.Color;

            var description = descriptionTextBox.Text;
            EditedExpense.Description = description;
            
            Close();
        }
    }
}
