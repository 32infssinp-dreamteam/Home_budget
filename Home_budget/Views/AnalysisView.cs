using Models.Models;
using Repository.Services;
using Services.BusinessServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_budget.Views
{
    public partial class AnalysisView : Form
    {
        private readonly CategoryService _categoryService = new CategoryService();
        private readonly ExpenseService _expenseService = new ExpenseService();
        private readonly ExpenseBusinessService _expenseBusinessService = new ExpenseBusinessService();
        private readonly MonthlyBudgetService _monthlyBudgetService = new MonthlyBudgetService();
        private readonly SummaryBusinessService _summaryBusinessService = new SummaryBusinessService();

        private List<Category> _categories;
        private List<Expense> _expenses;
        private List<SummaryData> _summaryData;

        public AnalysisView()
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
            _summaryData = _summaryBusinessService.GroupDataByDay(_expenses);

            //RefreshExpenseSum();
            RefreshDataBindings();
        }

        private void RefreshDataBindings()
        {
            bsSummaryData.DataSource = _summaryData;
            bsSummaryData.ResetBindings(false);
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void MonthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void SummaryDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= _summaryData.Count)
            {
                return;
            }

            var summaryData = _summaryData[e.RowIndex];
            e.CellStyle.BackColor = summaryData.CategoryColor;
            e.PaintBackground(e.ClipBounds, false);
        }
    }
}
