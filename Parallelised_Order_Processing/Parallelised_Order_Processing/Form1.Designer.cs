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
            this.LoadDataButton.Location = new System.Drawing.Point(12, 61);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(682, 38);
            this.LoadDataButton.TabIndex = 6;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // FileLoadingProgressBar
            // 
            this.FileLoadingProgressBar.Location = new System.Drawing.Point(12, 106);
            this.FileLoadingProgressBar.Name = "FileLoadingProgressBar";
            this.FileLoadingProgressBar.Size = new System.Drawing.Size(682, 23);
            this.FileLoadingProgressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
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
    }
}

