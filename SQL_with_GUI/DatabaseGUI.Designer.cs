namespace SQL_with_GUI
{
    partial class DatabaseGUI
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.tableNamesComboBox = new System.Windows.Forms.ComboBox();
            this.tableNamesChoiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(40, 139);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(292, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Enter data you need to find in database:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(44, 161);
            this.queryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(304, 24);
            this.queryTextBox.TabIndex = 4;
            this.queryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(454, 161);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(188, 24);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search in database";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultsListView
            // 
            this.resultsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultsListView.FullRowSelect = true;
            this.resultsListView.GridLines = true;
            this.resultsListView.Location = new System.Drawing.Point(44, 216);
            this.resultsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(598, 173);
            this.resultsListView.TabIndex = 8;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.View = System.Windows.Forms.View.Details;
            // 
            // tableNamesComboBox
            // 
            this.tableNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableNamesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableNamesComboBox.FormattingEnabled = true;
            this.tableNamesComboBox.Items.AddRange(new object[] {
            "as",
            "as",
            "d",
            "das"});
            this.tableNamesComboBox.Location = new System.Drawing.Point(44, 61);
            this.tableNamesComboBox.Name = "tableNamesComboBox";
            this.tableNamesComboBox.Size = new System.Drawing.Size(188, 26);
            this.tableNamesComboBox.TabIndex = 9;
            // 
            // tableNamesChoiceLabel
            // 
            this.tableNamesChoiceLabel.AutoSize = true;
            this.tableNamesChoiceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tableNamesChoiceLabel.Location = new System.Drawing.Point(40, 38);
            this.tableNamesChoiceLabel.Name = "tableNamesChoiceLabel";
            this.tableNamesChoiceLabel.Size = new System.Drawing.Size(111, 20);
            this.tableNamesChoiceLabel.TabIndex = 10;
            this.tableNamesChoiceLabel.Text = "Choose table: ";
            // 
            // DatabaseGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 529);
            this.Controls.Add(this.tableNamesChoiceLabel);
            this.Controls.Add(this.tableNamesComboBox);
            this.Controls.Add(this.resultsListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseGUI";
            this.Text = "Database with GUI - Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.ComboBox tableNamesComboBox;
        private System.Windows.Forms.Label tableNamesChoiceLabel;
    }
}

