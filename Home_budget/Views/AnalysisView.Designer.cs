namespace Home_budget.Views
{
    partial class AnalysisView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,20,30,40,50,60");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "30,20,50,40,10,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 45D);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.summaryDataGridView = new System.Windows.Forms.DataGridView();
            this.chartTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bsSummaryData = new System.Windows.Forms.BindingSource(this.components);
            this.dateStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.summaryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).BeginInit();
            this.chartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummaryData)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea2.Visible = false;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.bsSummaryData;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(747, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.summaryTabPage);
            this.tabControl1.Controls.Add(this.chartTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.Controls.Add(this.summaryDataGridView);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 22);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTabPage.Size = new System.Drawing.Size(753, 459);
            this.summaryTabPage.TabIndex = 0;
            this.summaryTabPage.Text = "Podsumowanie";
            this.summaryTabPage.UseVisualStyleBackColor = true;
            // 
            // summaryDataGridView
            // 
            this.summaryDataGridView.AllowUserToAddRows = false;
            this.summaryDataGridView.AllowUserToDeleteRows = false;
            this.summaryDataGridView.AllowUserToResizeRows = false;
            this.summaryDataGridView.AutoGenerateColumns = false;
            this.summaryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.summaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateStrDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.categoryColorDataGridViewTextBoxColumn});
            this.summaryDataGridView.DataSource = this.bsSummaryData;
            this.summaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.summaryDataGridView.Name = "summaryDataGridView";
            this.summaryDataGridView.ReadOnly = true;
            this.summaryDataGridView.RowHeadersVisible = false;
            this.summaryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.summaryDataGridView.ShowEditingIcon = false;
            this.summaryDataGridView.Size = new System.Drawing.Size(747, 453);
            this.summaryDataGridView.TabIndex = 0;
            this.summaryDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SummaryDataGridView_CellPainting);
            // 
            // chartTabPage
            // 
            this.chartTabPage.Controls.Add(this.chart1);
            this.chartTabPage.Location = new System.Drawing.Point(4, 22);
            this.chartTabPage.Name = "chartTabPage";
            this.chartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartTabPage.Size = new System.Drawing.Size(753, 459);
            this.chartTabPage.TabIndex = 1;
            this.chartTabPage.Text = "Wykres";
            this.chartTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.yearNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.monthNumericUpDown);
            this.splitContainer1.Size = new System.Drawing.Size(761, 530);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Miesiąc:";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(48, 9);
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
            this.yearNumericUpDown.TabIndex = 8;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.yearNumericUpDown.ValueChanged += new System.EventHandler(this.YearNumericUpDown_ValueChanged);
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(173, 9);
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
            this.monthNumericUpDown.TabIndex = 9;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.ValueChanged += new System.EventHandler(this.MonthNumericUpDown_ValueChanged);
            // 
            // bsSummaryData
            // 
            this.bsSummaryData.DataSource = typeof(Models.Models.SummaryData);
            // 
            // dateStrDataGridViewTextBoxColumn
            // 
            this.dateStrDataGridViewTextBoxColumn.DataPropertyName = "DateStr";
            this.dateStrDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dateStrDataGridViewTextBoxColumn.Name = "dateStrDataGridViewTextBoxColumn";
            this.dateStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Suma wydatków";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryColorDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.categoryColorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryColorDataGridViewTextBoxColumn.HeaderText = "";
            this.categoryColorDataGridViewTextBoxColumn.Name = "categoryColorDataGridViewTextBoxColumn";
            this.categoryColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AnalysisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AnalysisView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analiza wydatków";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.summaryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).EndInit();
            this.chartTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummaryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.DataGridView summaryDataGridView;
        private System.Windows.Forms.TabPage chartTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsSummaryData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColorDataGridViewTextBoxColumn;
    }
}