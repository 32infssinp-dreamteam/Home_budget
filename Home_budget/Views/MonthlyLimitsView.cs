using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Models.Models;
using Repository.Services;
using Services.BusinessServices;

namespace Home_budget.Views
{
    public partial class MonthlyLimitsView : Form
    {
        private readonly MonthlyBudgetService _monthlyBudgetService = new MonthlyBudgetService();
        private readonly MonthlyBudgetsBusinessService _monthlyBudgetsBusinessService = new MonthlyBudgetsBusinessService();

        private List<MonthlyBudget> _monthlyBudgets;
        private List<MonthlyBudget> _visibleMonthlyBudgets;
        private MonthlyBudget _selectedMonthlyBudget;
        private bool _isSaved = false;
        
        public MonthlyLimitsView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadAllMonthlyBudgets();

            SelectFirstOnList();
        }

        private void LoadAllMonthlyBudgets()
        {
            _monthlyBudgets = _monthlyBudgetService.GetAll();

            _visibleMonthlyBudgets = _monthlyBudgets;

            bsMonthlyBudgets.DataSource = _visibleMonthlyBudgets;
            bsMonthlyBudgets.ResetBindings(false);
        }

        private void MonthlyBudgetsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (monthlyBudgetsDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            var selectedRow = (MonthlyBudget) monthlyBudgetsDataGridView.SelectedRows[0].DataBoundItem;

            if (selectedRow == null)
            {
                return;
            }

            _selectedMonthlyBudget = selectedRow;

            bsSelectedMonthlyBudget.DataSource = _selectedMonthlyBudget;
            bsSelectedMonthlyBudget.ResetBindings(false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveChanges()
        {
            _monthlyBudgetsBusinessService.SaveChanges(_monthlyBudgets);
            _isSaved = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var newMonthlyBudget = new MonthlyBudget
            {
                Year = today.Year,
                Month = today.Month
            };

            newMonthlyBudget.MarkNew();

            _monthlyBudgets.Add(newMonthlyBudget);

            _selectedMonthlyBudget = newMonthlyBudget;
            bsSelectedMonthlyBudget.DataSource = _selectedMonthlyBudget;
            bsSelectedMonthlyBudget.ResetBindings(false);
            
            RefreshList();

            var currentItemIndex = _visibleMonthlyBudgets.Count - 1;

            monthlyBudgetsDataGridView.FirstDisplayedScrollingRowIndex = currentItemIndex;
            monthlyBudgetsDataGridView.Refresh();
            monthlyBudgetsDataGridView.CurrentCell = monthlyBudgetsDataGridView.Rows[currentItemIndex].Cells[0];
            monthlyBudgetsDataGridView.Rows[currentItemIndex].Selected = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _selectedMonthlyBudget.MarkDeleted();

            RefreshList();
            SelectFirstOnList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
            
            Close();
        }

        private void SelectFirstOnList()
        {
            if (_monthlyBudgets.Any(budget => !budget.IsDeleted))
            {
                monthlyBudgetsDataGridView.FirstDisplayedScrollingRowIndex = 0;
                monthlyBudgetsDataGridView.Refresh();
                monthlyBudgetsDataGridView.CurrentCell = monthlyBudgetsDataGridView.Rows[0].Cells[0];
                monthlyBudgetsDataGridView.Rows[0].Selected = true;

                _selectedMonthlyBudget = (MonthlyBudget)monthlyBudgetsDataGridView.Rows[0].DataBoundItem;
            }
            else
            {
                var today = DateTime.Today;

                _selectedMonthlyBudget = new MonthlyBudget
                {
                    Year = today.Year,
                    Month = today.Month
                };
            }

            bsSelectedMonthlyBudget.DataSource = _selectedMonthlyBudget;
            bsSelectedMonthlyBudget.ResetBindings(false);
        }

        private void RefreshList()
        {
            _visibleMonthlyBudgets = _monthlyBudgets.Where(budget => !budget.IsDeleted).ToList();
            bsMonthlyBudgets.DataSource = _visibleMonthlyBudgets;
            bsMonthlyBudgets.ResetBindings(false);
        }

        private void MonthlyBudgetsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved || !_monthlyBudgets.Any(budget => budget.IsDirty))
            {
                return;
            }

            if (MessageBox.Show("Czy wyjść bez zapisu zmian?", "Nie zapisano zmian", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
