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
            this.LoadDataDirectoryButton = new System.Windows.Forms.Button();
            this.SelectFolderLabel = new System.Windows.Forms.Label();
            this.DataDirectoryTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectStoreInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectStoreInfoLabel = new System.Windows.Forms.Label();
            this.SelectStoreInfoButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.FileLoadingProgressBar = new System.Windows.Forms.ProgressBar();
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
            this.DataDirectoryTextBox.Size = new System.Drawing.Size(298, 32);
            this.DataDirectoryTextBox.TabIndex = 2;
            this.DataDirectoryTextBox.Text = "";
            this.DataDirectoryTextBox.TextChanged += new System.EventHandler(this.DataDirectoryTextBox_TextChanged);
            // 
            // SelectStoreInfoTextBox
            // 
            this.SelectStoreInfoTextBox.Location = new System.Drawing.Point(396, 26);
            this.SelectStoreInfoTextBox.Multiline = false;
            this.SelectStoreInfoTextBox.Name = "SelectStoreInfoTextBox";
            this.SelectStoreInfoTextBox.ReadOnly = true;
            this.SelectStoreInfoTextBox.Size = new System.Drawing.Size(298, 32);
            this.SelectStoreInfoTextBox.TabIndex = 5;
            this.SelectStoreInfoTextBox.Text = "";
            this.SelectStoreInfoTextBox.TextChanged += new System.EventHandler(this.SelectStoreInfoTextBox_TextChanged);
            // 
            // SelectStoreInfoLabel
            // 
            this.SelectStoreInfoLabel.AutoSize = true;
            this.SelectStoreInfoLabel.Location = new System.Drawing.Point(358, 9);
            this.SelectStoreInfoLabel.Name = "SelectStoreInfoLabel";
            this.SelectStoreInfoLabel.Size = new System.Drawing.Size(139, 13);
            this.SelectStoreInfoLabel.TabIndex = 4;
            this.SelectStoreInfoLabel.Text = "Select Store Information File";
            // 
            // SelectStoreInfoButton
            // 
            this.SelectStoreInfoButton.BackgroundImage = global::Parallelised_Order_Processing.Properties.Resources.folder_1;
            this.SelectStoreInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectStoreInfoButton.Location = new System.Drawing.Point(361, 26);
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
            this.LoadDataButton.Size = new System.Drawing.Size(682, 38);
            this.LoadDataButton.TabIndex = 6;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // FileLoadingProgressBar
            // 
            this.FileLoadingProgressBar.Location = new System.Drawing.Point(12, 108);
            this.FileLoadingProgressBar.Name = "FileLoadingProgressBar";
            this.FileLoadingProgressBar.Size = new System.Drawing.Size(682, 14);
            this.FileLoadingProgressBar.TabIndex = 7;
            // 
            // StoresListBox
            // 
            this.StoresListBox.Enabled = false;
            this.StoresListBox.FormattingEnabled = true;
            this.StoresListBox.Location = new System.Drawing.Point(12, 145);
            this.StoresListBox.Name = "StoresListBox";
            this.StoresListBox.Size = new System.Drawing.Size(166, 186);
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
            this.SuppliersLabel.Location = new System.Drawing.Point(181, 129);
            this.SuppliersLabel.Name = "SuppliersLabel";
            this.SuppliersLabel.Size = new System.Drawing.Size(50, 13);
            this.SuppliersLabel.TabIndex = 11;
            this.SuppliersLabel.Text = "Suppliers";
            // 
            // SuppliersListBox
            // 
            this.SuppliersListBox.Enabled = false;
            this.SuppliersListBox.FormattingEnabled = true;
            this.SuppliersListBox.Location = new System.Drawing.Point(184, 145);
            this.SuppliersListBox.Name = "SuppliersListBox";
            this.SuppliersListBox.Size = new System.Drawing.Size(166, 186);
            this.SuppliersListBox.TabIndex = 10;
            this.SuppliersListBox.SelectedIndexChanged += new System.EventHandler(this.SuppliersListBox_SelectedIndexChanged);
            // 
            // SupplierTypesLabel
            // 
            this.SupplierTypesLabel.AutoSize = true;
            this.SupplierTypesLabel.Location = new System.Drawing.Point(353, 129);
            this.SupplierTypesLabel.Name = "SupplierTypesLabel";
            this.SupplierTypesLabel.Size = new System.Drawing.Size(77, 13);
            this.SupplierTypesLabel.TabIndex = 13;
            this.SupplierTypesLabel.Text = "Supplier Types";
            // 
            // SupplierTypesListBox
            // 
            this.SupplierTypesListBox.Enabled = false;
            this.SupplierTypesListBox.FormattingEnabled = true;
            this.SupplierTypesListBox.Location = new System.Drawing.Point(356, 145);
            this.SupplierTypesListBox.Name = "SupplierTypesListBox";
            this.SupplierTypesListBox.Size = new System.Drawing.Size(166, 186);
            this.SupplierTypesListBox.TabIndex = 12;
            this.SupplierTypesListBox.SelectedIndexChanged += new System.EventHandler(this.SupplierTypesListBox_SelectedIndexChanged);
            // 
            // DatesLabel
            // 
            this.DatesLabel.AutoSize = true;
            this.DatesLabel.Location = new System.Drawing.Point(525, 129);
            this.DatesLabel.Name = "DatesLabel";
            this.DatesLabel.Size = new System.Drawing.Size(35, 13);
            this.DatesLabel.TabIndex = 15;
            this.DatesLabel.Text = "Dates";
            // 
            // DatesListBox
            // 
            this.DatesListBox.Enabled = false;
            this.DatesListBox.FormattingEnabled = true;
            this.DatesListBox.Location = new System.Drawing.Point(528, 145);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(166, 186);
            this.DatesListBox.TabIndex = 14;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // ViewGraphButton
            // 
            this.ViewGraphButton.Enabled = false;
            this.ViewGraphButton.Location = new System.Drawing.Point(13, 337);
            this.ViewGraphButton.Name = "ViewGraphButton";
            this.ViewGraphButton.Size = new System.Drawing.Size(681, 38);
            this.ViewGraphButton.TabIndex = 16;
            this.ViewGraphButton.Text = "View orders from ALL stores, ALL suppliers, ALL supplier types and ALL dates";
            this.ViewGraphButton.UseVisualStyleBackColor = true;
            this.ViewGraphButton.Click += new System.EventHandler(this.ViewGraphButton_Click);
            // 
            // StoresDeselectLabel
            // 
            this.StoresDeselectLabel.AutoSize = true;
            this.StoresDeselectLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StoresDeselectLabel.Location = new System.Drawing.Point(129, 129);
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
            this.SuppliersDeactivateLabel.Location = new System.Drawing.Point(301, 129);
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
            this.SupplierTypesDeactivateLabel.Location = new System.Drawing.Point(473, 129);
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
            this.DateDeactivateLabel.Location = new System.Drawing.Point(645, 129);
            this.DateDeactivateLabel.Name = "DateDeactivateLabel";
            this.DateDeactivateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateDeactivateLabel.Size = new System.Drawing.Size(49, 13);
            this.DateDeactivateLabel.TabIndex = 20;
            this.DateDeactivateLabel.Text = "Deselect";
            this.DateDeactivateLabel.Click += new System.EventHandler(this.DateDeactivateLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 386);
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
            this.Controls.Add(this.FileLoadingProgressBar);
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
        private System.Windows.Forms.ProgressBar FileLoadingProgressBar;
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
    }
}

