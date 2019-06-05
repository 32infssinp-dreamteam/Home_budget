namespace Home_budget.Views
{
    partial class MonthlyLimitsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthlyBudgetsDataGridView = new System.Windows.Forms.DataGridView();
            this.bsMonthlyBudgets = new System.Windows.Forms.BindingSource(this.components);
            this.bsSelectedMonthlyBudget = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBudgetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedMonthlyBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyBudgetsDataGridView
            // 
            this.monthlyBudgetsDataGridView.AllowUserToAddRows = false;
            this.monthlyBudgetsDataGridView.AllowUserToDeleteRows = false;
            this.monthlyBudgetsDataGridView.AllowUserToResizeRows = false;
            this.monthlyBudgetsDataGridView.AutoGenerateColumns = false;
            this.monthlyBudgetsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.monthlyBudgetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyBudgetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.budgetValueDataGridViewTextBoxColumn});
            this.monthlyBudgetsDataGridView.DataSource = this.bsMonthlyBudgets;
            this.monthlyBudgetsDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthlyBudgetsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.monthlyBudgetsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.monthlyBudgetsDataGridView.MultiSelect = false;
            this.monthlyBudgetsDataGridView.Name = "monthlyBudgetsDataGridView";
            this.monthlyBudgetsDataGridView.ReadOnly = true;
            this.monthlyBudgetsDataGridView.RowHeadersVisible = false;
            this.monthlyBudgetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlyBudgetsDataGridView.ShowEditingIcon = false;
            this.monthlyBudgetsDataGridView.Size = new System.Drawing.Size(204, 311);
            this.monthlyBudgetsDataGridView.TabIndex = 0;
            this.monthlyBudgetsDataGridView.SelectionChanged += new System.EventHandler(this.MonthlyBudgetsDataGridView_SelectionChanged);
            // 
            // bsMonthlyBudgets
            // 
            this.bsMonthlyBudgets.DataSource = typeof(Models.Models.MonthlyBudget);
            // 
            // bsSelectedMonthlyBudget
            // 
            this.bsSelectedMonthlyBudget.DataSource = typeof(Models.Models.MonthlyBudget);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limit:";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(233, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(233, 276);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(233, 141);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(233, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Miesiąc:";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSelectedMonthlyBudget, "Year", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.yearNumericUpDown.Location = new System.Drawing.Point(262, 7);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.yearNumericUpDown.TabIndex = 13;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSelectedMonthlyBudget, "Month", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.monthNumericUpDown.Location = new System.Drawing.Point(262, 33);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.monthNumericUpDown.TabIndex = 14;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // limitNumericUpDown
            // 
            this.limitNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSelectedMonthlyBudget, "BudgetValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.limitNumericUpDown.DecimalPlaces = 2;
            this.limitNumericUpDown.Location = new System.Drawing.Point(262, 60);
            this.limitNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.limitNumericUpDown.Name = "limitNumericUpDown";
            this.limitNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.limitNumericUpDown.TabIndex = 15;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Miesiąc";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 50;
            // 
            // budgetValueDataGridViewTextBoxColumn
            // 
            this.budgetValueDataGridViewTextBoxColumn.DataPropertyName = "BudgetValue";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.budgetValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.budgetValueDataGridViewTextBoxColumn.HeaderText = "Limit";
            this.budgetValueDataGridViewTextBoxColumn.Name = "budgetValueDataGridViewTextBoxColumn";
            this.budgetValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MonthlyLimitsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 311);
            this.Controls.Add(this.limitNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.monthNumericUpDown);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlyBudgetsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MonthlyLimitsView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Miesięczne limity";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonthlyBudgetsView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBudgetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedMonthlyBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView monthlyBudgetsDataGridView;
        private System.Windows.Forms.BindingSource bsMonthlyBudgets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsSelectedMonthlyBudget;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown limitNumericUpDown;
    }
}