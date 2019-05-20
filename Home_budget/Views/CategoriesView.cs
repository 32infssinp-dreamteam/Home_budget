using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Models.Models;
using Repository.Services;

namespace Home_budget.Views
{
    public partial class CategoriesView : Form
    {
        private readonly CategoryService _categoryService = new CategoryService();

        private List<Category> _categories;
        private Category _selectedCategory;

        public CategoriesView(List<Category> categories)
        {
            InitializeComponent();

            _categories = categories;

            _categories = _categoryService.GetAll();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bsCategories.DataSource = _categories;
            bsCategories.ResetBindings(false);

            if (_categories.Any())
            {
                _selectedCategory = _categories.First();

                bsSelectedCategory.DataSource = _selectedCategory;
                bsSelectedCategory.ResetBindings(false);
            }
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
                
                bsCategories.ResetBindings(false);
                categoriesDataGridView.Refresh();
            }
        }

        private void CategoriesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex != 1)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= _categories.Count)
            {
                return;
            }

            var category = _categories[e.RowIndex];
            e.CellStyle.BackColor = category.Color;
        }

        private void CategoriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (categoriesDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            _selectedCategory = (Category) categoriesDataGridView.SelectedRows[0].DataBoundItem;
            bsSelectedCategory.DataSource = _selectedCategory;
            bsSelectedCategory.ResetBindings(false);
        }
    }
}
