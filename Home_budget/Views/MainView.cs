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
using Services.BusinessServices;

namespace Home_budget.Views
{
    public partial class MainView : Form
    {
        private readonly  CategoryService _categoryService = new CategoryService();
        private readonly ExpenseService _expenseService = new ExpenseService();
        private readonly ExpenseBusinessService _expenseBusinessService = new ExpenseBusinessService();
        private readonly MonthlyBudgetService _monthlyBudgetService = new MonthlyBudgetService();

        private List<Category> _categories;
        private List<Expense> _expenses;

        public MainView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            _categories = _categoryService.GetAll();

            InitializeGUI();

            ReloadData();
        }

        private void InitializeGUI()
        {
            var today = DateTime.Today;
            yearNumericUpDown.Value = today.Year;
            monthNumericUpDown.Value = today.Month;
        }
        
        private void ReloadData()
        {
            _expenses = _expenseService.GetByMonth((int)yearNumericUpDown.Value, (int)monthNumericUpDown.Value);
            _expenseBusinessService.FillCategoryInfos(_expenses, _categories);

            RefreshExpenseSum();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            bsExpense.DataSource = _expenses;
            bsExpense.ResetBindings(false);
        }

        private void RefreshExpenseSum()
        {
            var expenseMonthlySum = _expenses.Sum(exp => exp.Value);
            var monthlyLimitValue = _monthlyBudgetService.Get((int) yearNumericUpDown.Value, (int) monthNumericUpDown.Value)?.BudgetValue ?? 0m;
            var usedExpensesLimitText = $"{expenseMonthlySum} zł/{monthlyLimitValue} zł";
            var textColor = (expenseMonthlySum >= monthlyLimitValue)
                ? Color.DarkRed
                : (expenseMonthlySum >= 0.85m * monthlyLimitValue)
                    ? Color.DarkOrange
                    : Color.DarkGreen;

            expenseSumLabel.Text = usedExpensesLimitText;
            expenseSumLabel.ForeColor = textColor;
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void MonthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            var newExpense = new Expense();
            newExpense.MarkNew();

            using (var expenseEditDialog = new ExpenseEditView(_categories, newExpense))
            {
                if (expenseEditDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _expenseService.Add(newExpense);

                if (newExpense.Year == yearNumericUpDown.Value && newExpense.Month == monthNumericUpDown.Value)
                {
                    _expenses.Add(newExpense);
                }

                RefreshGrid();
                RefreshExpenseSum();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (expensesDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            var editedExpense = (Expense)expensesDataGridView.SelectedRows[0].DataBoundItem;

            using (var expenseEditDialog = new ExpenseEditView(_categories, editedExpense))
            {
                if (expenseEditDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                _expenseService.Edit(editedExpense);
                
                RefreshGrid();
                RefreshExpenseSum();
            }
        }

        private void ExpensesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= _expenses.Count)
            {
                return;
            }

            var expense = _expenses[e.RowIndex];
            e.CellStyle.BackColor = expense.CategoryColor;
            e.PaintBackground(e.ClipBounds, false);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (expensesDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            var expense = (Expense)expensesDataGridView.SelectedRows[0].DataBoundItem;

            _expenseService.Delete(expense);

            _expenses.Remove(expense);

            RefreshGrid();
            RefreshExpenseSum();
        }

        private void EditCategoriesButton_Click(object sender, EventArgs e)
        {
            using (var categoryEditDialog = new CategoriesView(_categories))
            {
                categoryEditDialog.ShowDialog();

                _categories = _categoryService.GetAll();
                _expenseBusinessService.FillCategoryInfos(_expenses, _categories);
                Refresh();
            }
        }

        private void EditMonthlyBudgetsButton_Click(object sender, EventArgs e)
        {
            using (var monthlyBudgetsEditDialog = new MonthlyLimitsView())
            {
                monthlyBudgetsEditDialog.ShowDialog();
            }
        }

        private void ShowAnalysisButton_Click(object sender, EventArgs e)
        {
            using (var analysisView = new AnalysisView())
            {
                analysisView.ShowDialog();
            }
        }
    }
}
