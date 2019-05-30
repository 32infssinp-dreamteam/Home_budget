namespace Home_budget.Views
{
    partial class CategoriesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.colorSelectionButton = new System.Windows.Forms.Button();
            this.showColorTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.bsCategoriesViewGuiProperties = new System.Windows.Forms.BindingSource(this.components);
            this.bsSelectedCategory = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoriesViewGuiProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToAddRows = false;
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.AllowUserToResizeRows = false;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Color});
            this.categoriesDataGridView.DataSource = this.bsCategories;
            this.categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesDataGridView.MultiSelect = false;
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            this.categoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriesDataGridView.ShowEditingIcon = false;
            this.categoriesDataGridView.Size = new System.Drawing.Size(292, 310);
            this.categoriesDataGridView.TabIndex = 0;
            this.categoriesDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CategoriesDataGridView_CellPainting);
            this.categoriesDataGridView.SelectionChanged += new System.EventHandler(this.CategoriesDataGridView_SelectionChanged);
            // 
            // Color
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Color.DefaultCellStyle = dataGridViewCellStyle4;
            this.Color.HeaderText = "Kolor";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Color.Width = 40;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedCategory, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.bsCategoriesViewGuiProperties, "IsCategoryDetailsReadonly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(314, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolor";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedCategory, "ColorText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.colorTextBox.Location = new System.Drawing.Point(314, 99);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(89, 20);
            this.colorTextBox.TabIndex = 4;
            // 
            // colorSelectionButton
            // 
            this.colorSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSelectionButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsCategoriesViewGuiProperties, "IsButtonEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.colorSelectionButton.Location = new System.Drawing.Point(435, 97);
            this.colorSelectionButton.Name = "colorSelectionButton";
            this.colorSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.colorSelectionButton.TabIndex = 5;
            this.colorSelectionButton.Text = "Wybierz";
            this.colorSelectionButton.UseVisualStyleBackColor = true;
            this.colorSelectionButton.Click += new System.EventHandler(this.ColorSelectionButton_Click);
            // 
            // showColorTextBox
            // 
            this.showColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.bsSelectedCategory, "Color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showColorTextBox.Location = new System.Drawing.Point(409, 99);
            this.showColorTextBox.Name = "showColorTextBox";
            this.showColorTextBox.ReadOnly = true;
            this.showColorTextBox.Size = new System.Drawing.Size(20, 20);
            this.showColorTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(314, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(435, 275);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsCategoriesViewGuiProperties, "IsButtonEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteButton.Location = new System.Drawing.Point(435, 186);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(314, 186);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // bsCategoriesViewGuiProperties
            // 
            this.bsCategoriesViewGuiProperties.DataSource = typeof(Models.Models.CategoriesViewGuiProperties);
            // 
            // bsSelectedCategory
            // 
            this.bsSelectedCategory.DataSource = typeof(Models.Models.Category);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsCategories
            // 
            this.bsCategories.DataSource = typeof(Models.Models.Category);
            // 
            // CategoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 310);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showColorTextBox);
            this.Controls.Add(this.colorSelectionButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.categoriesDataGridView);
            this.Name = "CategoriesView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Kategorie wydatków";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoriesView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoriesViewGuiProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button colorSelectionButton;
        private System.Windows.Forms.TextBox showColorTextBox;
        private System.Windows.Forms.BindingSource bsSelectedCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingSource bsCategoriesViewGuiProperties;
    }
}