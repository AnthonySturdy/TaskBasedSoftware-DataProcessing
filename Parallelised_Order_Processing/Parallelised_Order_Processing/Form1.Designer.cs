namespace Parallelised_Order_Processing {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LoadDataDirectoryButton = new System.Windows.Forms.Button();
            this.SelectFolderLabel = new System.Windows.Forms.Label();
            this.DataDirectoryTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectStoreInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectStoreInfoLabel = new System.Windows.Forms.Label();
            this.SelectStoreInfoButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.StoresListBox = new System.Windows.Forms.ListBox();
            this.StoresLabel = new System.Windows.Forms.Label();
            this.SuppliersLabel = new System.Windows.Forms.Label();
            this.SuppliersListBox = new System.Windows.Forms.ListBox();
            this.SupplierTypesLabel = new System.Windows.Forms.Label();
            this.SupplierTypesListBox = new System.Windows.Forms.ListBox();
            this.DatesLabel = new System.Windows.Forms.Label();
            this.DatesListBox = new System.Windows.Forms.ListBox();
            this.ViewGraphButton = new System.Windows.Forms.Button();
            this.StoresDeselectLabel = new System.Windows.Forms.Label();
            this.SuppliersDeactivateLabel = new System.Windows.Forms.Label();
            this.SupplierTypesDeactivateLabel = new System.Windows.Forms.Label();
            this.DateDeactivateLabel = new System.Windows.Forms.Label();
            this.StoresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SupplierChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SupplierTypesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DatesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FilteredOrdersListView = new System.Windows.Forms.ListView();
            this.Store = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StoresChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTypesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDataDirectoryButton
            // 
            this.LoadDataDirectoryButton.BackgroundImage = global::Parallelised_Order_Processing.Properties.Resources.folder_1;
            this.LoadDataDirectoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadDataDirectoryButton.Location = new System.Drawing.Point(12, 26);
            this.LoadDataDirectoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoadDataDirectoryButton.Name = "LoadDataDirectoryButton";
            this.LoadDataDirectoryButton.Size = new System.Drawing.Size(32, 32);
            this.LoadDataDirectoryButton.TabIndex = 0;
            this.LoadDataDirectoryButton.UseVisualStyleBackColor = true;
            this.LoadDataDirectoryButton.Click += new System.EventHandler(this.LoadDataDirectoryButton_Click);
            // 
            // SelectFolderLabel
            // 
            this.SelectFolderLabel.AutoSize = true;
            this.SelectFolderLabel.Location = new System.Drawing.Point(9, 9);
            this.SelectFolderLabel.Name = "SelectFolderLabel";
            this.SelectFolderLabel.Size = new System.Drawing.Size(124, 13);
            this.SelectFolderLabel.TabIndex = 1;
            this.SelectFolderLabel.Text = "Select Order Data Folder";
            // 
            // DataDirectoryTextBox
            // 
            this.DataDirectoryTextBox.Location = new System.Drawing.Point(47, 26);
            this.DataDirectoryTextBox.Multiline = false;
            this.DataDirectoryTextBox.Name = "DataDirectoryTextBox";
            this.DataDirectoryTextBox.ReadOnly = true;
            this.DataDirectoryTextBox.Size = new System.Drawing.Size(216, 32);
            this.DataDirectoryTextBox.TabIndex = 2;
            this.DataDirectoryTextBox.Text = "";
            this.DataDirectoryTextBox.TextChanged += new System.EventHandler(this.DataDirectoryTextBox_TextChanged);
            // 
            // SelectStoreInfoTextBox
            // 
            this.SelectStoreInfoTextBox.Location = new System.Drawing.Point(334, 26);
            this.SelectStoreInfoTextBox.Multiline = false;
            this.SelectStoreInfoTextBox.Name = "SelectStoreInfoTextBox";
            this.SelectStoreInfoTextBox.ReadOnly = true;
            this.SelectStoreInfoTextBox.Size = new System.Drawing.Size(216, 32);
            this.SelectStoreInfoTextBox.TabIndex = 5;
            this.SelectStoreInfoTextBox.Text = "";
            this.SelectStoreInfoTextBox.TextChanged += new System.EventHandler(this.SelectStoreInfoTextBox_TextChanged);
            // 
            // SelectStoreInfoLabel
            // 
            this.SelectStoreInfoLabel.AutoSize = true;
            this.SelectStoreInfoLabel.Location = new System.Drawing.Point(296, 9);
            this.SelectStoreInfoLabel.Name = "SelectStoreInfoLabel";
            this.SelectStoreInfoLabel.Size = new System.Drawing.Size(139, 13);
            this.SelectStoreInfoLabel.TabIndex = 4;
            this.SelectStoreInfoLabel.Text = "Select Store Information File";
            // 
            // SelectStoreInfoButton
            // 
            this.SelectStoreInfoButton.BackgroundImage = global::Parallelised_Order_Processing.Properties.Resources.folder_1;
            this.SelectStoreInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectStoreInfoButton.Location = new System.Drawing.Point(299, 26);
            this.SelectStoreInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectStoreInfoButton.Name = "SelectStoreInfoButton";
            this.SelectStoreInfoButton.Size = new System.Drawing.Size(32, 32);
            this.SelectStoreInfoButton.TabIndex = 3;
            this.SelectStoreInfoButton.UseVisualStyleBackColor = true;
            this.SelectStoreInfoButton.Click += new System.EventHandler(this.SelectStoreInfoButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Enabled = false;
            this.LoadDataButton.Location = new System.Drawing.Point(12, 64);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(538, 62);
            this.LoadDataButton.TabIndex = 6;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // StoresListBox
            // 
            this.StoresListBox.Enabled = false;
            this.StoresListBox.FormattingEnabled = true;
            this.StoresListBox.Location = new System.Drawing.Point(12, 145);
            this.StoresListBox.Name = "StoresListBox";
            this.StoresListBox.Size = new System.Drawing.Size(130, 342);
            this.StoresListBox.TabIndex = 8;
            this.StoresListBox.SelectedIndexChanged += new System.EventHandler(this.StoresListBox_SelectedIndexChanged);
            // 
            // StoresLabel
            // 
            this.StoresLabel.AutoSize = true;
            this.StoresLabel.Location = new System.Drawing.Point(9, 129);
            this.StoresLabel.Name = "StoresLabel";
            this.StoresLabel.Size = new System.Drawing.Size(37, 13);
            this.StoresLabel.TabIndex = 9;
            this.StoresLabel.Text = "Stores";
            // 
            // SuppliersLabel
            // 
            this.SuppliersLabel.AutoSize = true;
            this.SuppliersLabel.Location = new System.Drawing.Point(145, 129);
            this.SuppliersLabel.Name = "SuppliersLabel";
            this.SuppliersLabel.Size = new System.Drawing.Size(50, 13);
            this.SuppliersLabel.TabIndex = 11;
            this.SuppliersLabel.Text = "Suppliers";
            // 
            // SuppliersListBox
            // 
            this.SuppliersListBox.Enabled = false;
            this.SuppliersListBox.FormattingEnabled = true;
            this.SuppliersListBox.Location = new System.Drawing.Point(148, 145);
            this.SuppliersListBox.Name = "SuppliersListBox";
            this.SuppliersListBox.Size = new System.Drawing.Size(130, 342);
            this.SuppliersListBox.TabIndex = 10;
            this.SuppliersListBox.SelectedIndexChanged += new System.EventHandler(this.SuppliersListBox_SelectedIndexChanged);
            // 
            // SupplierTypesLabel
            // 
            this.SupplierTypesLabel.AutoSize = true;
            this.SupplierTypesLabel.Location = new System.Drawing.Point(281, 129);
            this.SupplierTypesLabel.Name = "SupplierTypesLabel";
            this.SupplierTypesLabel.Size = new System.Drawing.Size(77, 13);
            this.SupplierTypesLabel.TabIndex = 13;
            this.SupplierTypesLabel.Text = "Supplier Types";
            // 
            // SupplierTypesListBox
            // 
            this.SupplierTypesListBox.Enabled = false;
            this.SupplierTypesListBox.FormattingEnabled = true;
            this.SupplierTypesListBox.Location = new System.Drawing.Point(284, 145);
            this.SupplierTypesListBox.Name = "SupplierTypesListBox";
            this.SupplierTypesListBox.Size = new System.Drawing.Size(130, 342);
            this.SupplierTypesListBox.TabIndex = 12;
            this.SupplierTypesListBox.SelectedIndexChanged += new System.EventHandler(this.SupplierTypesListBox_SelectedIndexChanged);
            // 
            // DatesLabel
            // 
            this.DatesLabel.AutoSize = true;
            this.DatesLabel.Location = new System.Drawing.Point(417, 129);
            this.DatesLabel.Name = "DatesLabel";
            this.DatesLabel.Size = new System.Drawing.Size(35, 13);
            this.DatesLabel.TabIndex = 15;
            this.DatesLabel.Text = "Dates";
            // 
            // DatesListBox
            // 
            this.DatesListBox.Enabled = false;
            this.DatesListBox.FormattingEnabled = true;
            this.DatesListBox.Location = new System.Drawing.Point(420, 145);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(130, 342);
            this.DatesListBox.TabIndex = 14;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // ViewGraphButton
            // 
            this.ViewGraphButton.Enabled = false;
            this.ViewGraphButton.Location = new System.Drawing.Point(12, 493);
            this.ViewGraphButton.Name = "ViewGraphButton";
            this.ViewGraphButton.Size = new System.Drawing.Size(538, 44);
            this.ViewGraphButton.TabIndex = 16;
            this.ViewGraphButton.Text = "View orders from ALL stores, ALL suppliers, ALL supplier types and ALL dates";
            this.ViewGraphButton.UseVisualStyleBackColor = true;
            this.ViewGraphButton.Click += new System.EventHandler(this.ViewGraphButton_Click);
            // 
            // StoresDeselectLabel
            // 
            this.StoresDeselectLabel.AutoSize = true;
            this.StoresDeselectLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StoresDeselectLabel.Location = new System.Drawing.Point(93, 129);
            this.StoresDeselectLabel.Name = "StoresDeselectLabel";
            this.StoresDeselectLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StoresDeselectLabel.Size = new System.Drawing.Size(49, 13);
            this.StoresDeselectLabel.TabIndex = 17;
            this.StoresDeselectLabel.Text = "Deselect";
            this.StoresDeselectLabel.Click += new System.EventHandler(this.StoresDeselectLabel_Click);
            // 
            // SuppliersDeactivateLabel
            // 
            this.SuppliersDeactivateLabel.AutoSize = true;
            this.SuppliersDeactivateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SuppliersDeactivateLabel.Location = new System.Drawing.Point(229, 129);
            this.SuppliersDeactivateLabel.Name = "SuppliersDeactivateLabel";
            this.SuppliersDeactivateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuppliersDeactivateLabel.Size = new System.Drawing.Size(49, 13);
            this.SuppliersDeactivateLabel.TabIndex = 18;
            this.SuppliersDeactivateLabel.Text = "Deselect";
            this.SuppliersDeactivateLabel.Click += new System.EventHandler(this.SuppliersDeactivateLabel_Click);
            // 
            // SupplierTypesDeactivateLabel
            // 
            this.SupplierTypesDeactivateLabel.AutoSize = true;
            this.SupplierTypesDeactivateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierTypesDeactivateLabel.Location = new System.Drawing.Point(365, 129);
            this.SupplierTypesDeactivateLabel.Name = "SupplierTypesDeactivateLabel";
            this.SupplierTypesDeactivateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SupplierTypesDeactivateLabel.Size = new System.Drawing.Size(49, 13);
            this.SupplierTypesDeactivateLabel.TabIndex = 19;
            this.SupplierTypesDeactivateLabel.Text = "Deselect";
            this.SupplierTypesDeactivateLabel.Click += new System.EventHandler(this.SupplierTypesDeactivateLabel_Click);
            // 
            // DateDeactivateLabel
            // 
            this.DateDeactivateLabel.AutoSize = true;
            this.DateDeactivateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DateDeactivateLabel.Location = new System.Drawing.Point(501, 129);
            this.DateDeactivateLabel.Name = "DateDeactivateLabel";
            this.DateDeactivateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateDeactivateLabel.Size = new System.Drawing.Size(49, 13);
            this.DateDeactivateLabel.TabIndex = 20;
            this.DateDeactivateLabel.Text = "Deselect";
            this.DateDeactivateLabel.Click += new System.EventHandler(this.DateDeactivateLabel_Click);
            // 
            // StoresChart
            // 
            chartArea5.Name = "ChartArea1";
            this.StoresChart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.StoresChart.Legends.Add(legend5);
            this.StoresChart.Location = new System.Drawing.Point(556, 9);
            this.StoresChart.Name = "StoresChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.StoresChart.Series.Add(series5);
            this.StoresChart.Size = new System.Drawing.Size(776, 250);
            this.StoresChart.TabIndex = 21;
            this.StoresChart.Text = "StoresChart";
            title5.Name = "StoresTitle";
            title5.Text = "Stores";
            this.StoresChart.Titles.Add(title5);
            // 
            // SupplierChart
            // 
            chartArea6.Name = "ChartArea1";
            this.SupplierChart.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.SupplierChart.Legends.Add(legend6);
            this.SupplierChart.Location = new System.Drawing.Point(556, 521);
            this.SupplierChart.Name = "SupplierChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.SupplierChart.Series.Add(series6);
            this.SupplierChart.Size = new System.Drawing.Size(528, 250);
            this.SupplierChart.TabIndex = 22;
            this.SupplierChart.Text = "StoresChart";
            title6.Name = "SuppliersTitle";
            title6.Text = "Suppliers";
            this.SupplierChart.Titles.Add(title6);
            // 
            // SupplierTypesChart
            // 
            chartArea7.Name = "ChartArea1";
            this.SupplierTypesChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.SupplierTypesChart.Legends.Add(legend7);
            this.SupplierTypesChart.Location = new System.Drawing.Point(1090, 521);
            this.SupplierTypesChart.Name = "SupplierTypesChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.SupplierTypesChart.Series.Add(series7);
            this.SupplierTypesChart.Size = new System.Drawing.Size(242, 250);
            this.SupplierTypesChart.TabIndex = 23;
            this.SupplierTypesChart.Text = "StoresChart";
            title7.Name = "SupplierTypesTitle";
            title7.Text = "Supplier Types";
            this.SupplierTypesChart.Titles.Add(title7);
            // 
            // DatesChart
            // 
            chartArea8.Name = "ChartArea1";
            this.DatesChart.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.DatesChart.Legends.Add(legend8);
            this.DatesChart.Location = new System.Drawing.Point(556, 265);
            this.DatesChart.Name = "DatesChart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.DatesChart.Series.Add(series8);
            this.DatesChart.Size = new System.Drawing.Size(776, 250);
            this.DatesChart.TabIndex = 24;
            this.DatesChart.Text = "StoresChart";
            title8.Name = "DatesTitle";
            title8.Text = "Dates";
            this.DatesChart.Titles.Add(title8);
            // 
            // FilteredOrdersListView
            // 
            this.FilteredOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Store,
            this.Supplier,
            this.SupplierType,
            this.Date,
            this.Cost});
            this.FilteredOrdersListView.FullRowSelect = true;
            this.FilteredOrdersListView.GridLines = true;
            this.FilteredOrdersListView.HideSelection = false;
            this.FilteredOrdersListView.Location = new System.Drawing.Point(12, 560);
            this.FilteredOrdersListView.Name = "FilteredOrdersListView";
            this.FilteredOrdersListView.Size = new System.Drawing.Size(538, 211);
            this.FilteredOrdersListView.TabIndex = 25;
            this.FilteredOrdersListView.UseCompatibleStateImageBehavior = false;
            this.FilteredOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // Store
            // 
            this.Store.Text = "Store";
            this.Store.Width = 109;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 114;
            // 
            // SupplierType
            // 
            this.SupplierType.Text = "Supplier Type";
            this.SupplierType.Width = 144;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 94;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 73;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(9, 544);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(73, 13);
            this.TotalCostLabel.TabIndex = 26;
            this.TotalCostLabel.Text = "Total Cost: £0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 787);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.FilteredOrdersListView);
            this.Controls.Add(this.DatesChart);
            this.Controls.Add(this.SupplierTypesChart);
            this.Controls.Add(this.SupplierChart);
            this.Controls.Add(this.StoresChart);
            this.Controls.Add(this.DateDeactivateLabel);
            this.Controls.Add(this.SupplierTypesDeactivateLabel);
            this.Controls.Add(this.SuppliersDeactivateLabel);
            this.Controls.Add(this.StoresDeselectLabel);
            this.Controls.Add(this.ViewGraphButton);
            this.Controls.Add(this.DatesLabel);
            this.Controls.Add(this.DatesListBox);
            this.Controls.Add(this.SupplierTypesLabel);
            this.Controls.Add(this.SupplierTypesListBox);
            this.Controls.Add(this.SuppliersLabel);
            this.Controls.Add(this.SuppliersListBox);
            this.Controls.Add(this.StoresLabel);
            this.Controls.Add(this.StoresListBox);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.SelectStoreInfoTextBox);
            this.Controls.Add(this.SelectStoreInfoLabel);
            this.Controls.Add(this.SelectStoreInfoButton);
            this.Controls.Add(this.DataDirectoryTextBox);
            this.Controls.Add(this.SelectFolderLabel);
            this.Controls.Add(this.LoadDataDirectoryButton);
            this.Name = "Form1";
            this.Text = "Order Data Visualisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoresChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTypesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataDirectoryButton;
        private System.Windows.Forms.Label SelectFolderLabel;
        private System.Windows.Forms.RichTextBox DataDirectoryTextBox;
        private System.Windows.Forms.RichTextBox SelectStoreInfoTextBox;
        private System.Windows.Forms.Label SelectStoreInfoLabel;
        private System.Windows.Forms.Button SelectStoreInfoButton;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.ListBox StoresListBox;
        private System.Windows.Forms.Label StoresLabel;
        private System.Windows.Forms.Label SuppliersLabel;
        private System.Windows.Forms.ListBox SuppliersListBox;
        private System.Windows.Forms.Label SupplierTypesLabel;
        private System.Windows.Forms.ListBox SupplierTypesListBox;
        private System.Windows.Forms.Label DatesLabel;
        private System.Windows.Forms.ListBox DatesListBox;
        private System.Windows.Forms.Button ViewGraphButton;
        private System.Windows.Forms.Label StoresDeselectLabel;
        private System.Windows.Forms.Label SuppliersDeactivateLabel;
        private System.Windows.Forms.Label SupplierTypesDeactivateLabel;
        private System.Windows.Forms.Label DateDeactivateLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart StoresChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SupplierChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SupplierTypesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DatesChart;
        private System.Windows.Forms.ListView FilteredOrdersListView;
        private System.Windows.Forms.ColumnHeader Store;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader SupplierType;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label TotalCostLabel;
    }
}

