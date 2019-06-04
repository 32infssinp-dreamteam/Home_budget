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
        private readonly CategoryService _categoryService = new CategoryService();
        private readonly CategoryBusinessService _categoryBusinessService = new CategoryBusinessService();

        private List<Category> _categories;
        private List<Category> _visibleCategories;
        private Category _selectedCategory;
        private CategoriesViewGuiProperties _guiProperties = new CategoriesViewGuiProperties();
        private bool _isSaved = false;
        
        public MonthlyLimitsView(List<Category> categories)
        {
            InitializeComponent();

            _categories = categories;
            
            _visibleCategories = _categories;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bsCategories.DataSource = _visibleCategories;
            bsCategories.ResetBindings(false);
            
            bsCategoriesViewGuiProperties.DataSource = _guiProperties;
            bsCategoriesViewGuiProperties.ResetBindings(false);
            
            SelectFirstOnList();
        }

        private void ColorSelectionButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var color = dialog.Color;
                _selectedCategory.Color = color;
                _selectedCategory.ColorText = ColorTranslator.ToHtml(color);
                
                categoriesDataGridView.Refresh();
            }
        }

        private void CategoriesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= _visibleCategories.Count)
            {
                return;
            }

            var category = _visibleCategories[e.RowIndex];
            e.CellStyle.BackColor = category.Color;
            e.PaintBackground(e.ClipBounds, false);
        }

        private void CategoriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (categoriesDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            var selectedRow = (Category) categoriesDataGridView.SelectedRows[0].DataBoundItem;

            if (selectedRow == null)
            {
                return;
            }

            _selectedCategory = selectedRow;

            bsSelectedCategory.DataSource = _selectedCategory;
            bsSelectedCategory.ResetBindings(false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetChanges()
        {
            _categories = _categoryService.GetAll();
            _visibleCategories = _categories;
        }

        private void SaveChanges()
        {
            _categoryBusinessService.SaveChanges(_categories);
            _isSaved = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newCategory = new Category
            {
                Color = System.Drawing.Color.White
            };

            newCategory.MarkNew();

            _categories.Add(newCategory);

            _selectedCategory = newCategory;
            bsSelectedCategory.DataSource = _selectedCategory;
            bsSelectedCategory.ResetBindings(false);

            _guiProperties.IsCategoryDetailsReadonly = false;
            bsCategoriesViewGuiProperties.ResetBindings(false);

            RefreshList();

            var currentItemIndex = _visibleCategories.Count - 1;

            categoriesDataGridView.FirstDisplayedScrollingRowIndex = currentItemIndex;
            categoriesDataGridView.Refresh();
            categoriesDataGridView.CurrentCell = categoriesDataGridView.Rows[currentItemIndex].Cells[0];
            categoriesDataGridView.Rows[currentItemIndex].Selected = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_categoryService.IsCategoryUsed(_selectedCategory))
            {
                MessageBox.Show("Nie można usunąć kategorii, która została przypisana do wydatku", "Błąd", MessageBoxButtons.OK);

                return;
            }

            _selectedCategory.MarkDeleted();

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
            if (_categories.Any(cat => !cat.IsDeleted))
            {
                categoriesDataGridView.FirstDisplayedScrollingRowIndex = 0;
                categoriesDataGridView.Refresh();
                categoriesDataGridView.CurrentCell = categoriesDataGridView.Rows[0].Cells[0];
                categoriesDataGridView.Rows[0].Selected = true;

                _selectedCategory = (Category)categoriesDataGridView.Rows[0].DataBoundItem;

                _guiProperties.IsCategoryDetailsReadonly = false;
            }
            else
            {
                _selectedCategory = new Category();

                _guiProperties.IsCategoryDetailsReadonly = true;
            }

            bsSelectedCategory.DataSource = _selectedCategory;
            bsSelectedCategory.ResetBindings(false);
            bsCategoriesViewGuiProperties.ResetBindings(false);
        }

        private void RefreshList()
        {
            _visibleCategories = _categories.Where(cat => !cat.IsDeleted).ToList();
            bsCategories.DataSource = _visibleCategories;
            bsCategories.ResetBindings(false);
        }

        private void CategoriesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved || !_categories.Any(cat => cat.IsDirty))
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
