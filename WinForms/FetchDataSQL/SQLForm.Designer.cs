namespace FetchDataSQL
{
    partial class SQLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLForm));
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLHelpLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SQLGroupbox = new System.Windows.Forms.GroupBox();
            this.SQLQueryLabel = new System.Windows.Forms.Label();
            this.SQLQueryTextbox = new System.Windows.Forms.TextBox();
            this.BatchSizeHelpLabel = new System.Windows.Forms.Label();
            this.PageHelpLabel = new System.Windows.Forms.Label();
            this.BatchSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.PageNUD = new System.Windows.Forms.NumericUpDown();
            this.PageLabel = new System.Windows.Forms.Label();
            this.BatchSizeLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ServerGroupbox = new System.Windows.Forms.GroupBox();
            this.LoginGroupbox = new System.Windows.Forms.GroupBox();
            this.CompanyIDTextbox = new System.Windows.Forms.TextBox();
            this.CompanyIDLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.AuthenticationHelpLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.APIKeyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.OrLabel = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultsHeaderPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.ResultsPanelLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.SQLGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNUD)).BeginInit();
            this.ServerGroupbox.SuspendLayout();
            this.LoginGroupbox.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.ResultsHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(58, 19);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(289, 20);
            this.URLTextbox.TabIndex = 0;
            this.URLTextbox.Text = "http://server/odyssey/oodapi";
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(9, 22);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(49, 13);
            this.URLLabel.TabIndex = 1;
            this.URLLabel.Text = "API URL";
            // 
            // URLHelpLabel
            // 
            this.URLHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLHelpLabel.Location = new System.Drawing.Point(9, 49);
            this.URLHelpLabel.Name = "URLHelpLabel";
            this.URLHelpLabel.Size = new System.Drawing.Size(341, 31);
            this.URLHelpLabel.TabIndex = 2;
            this.URLHelpLabel.Text = "The path to your OODAPI. For on-premise, this is usually the location to your Ody" +
    "ssey install, followed by /OODAPI";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.SQLGroupbox);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.ServerGroupbox);
            this.HeaderPanel.Controls.Add(this.LoginGroupbox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 330);
            this.HeaderPanel.TabIndex = 3;
            // 
            // SQLGroupbox
            // 
            this.SQLGroupbox.Controls.Add(this.SQLQueryLabel);
            this.SQLGroupbox.Controls.Add(this.SQLQueryTextbox);
            this.SQLGroupbox.Controls.Add(this.BatchSizeHelpLabel);
            this.SQLGroupbox.Controls.Add(this.PageHelpLabel);
            this.SQLGroupbox.Controls.Add(this.BatchSizeNUD);
            this.SQLGroupbox.Controls.Add(this.PageNUD);
            this.SQLGroupbox.Controls.Add(this.PageLabel);
            this.SQLGroupbox.Controls.Add(this.BatchSizeLabel);
            this.SQLGroupbox.Location = new System.Drawing.Point(388, 47);
            this.SQLGroupbox.Name = "SQLGroupbox";
            this.SQLGroupbox.Size = new System.Drawing.Size(400, 270);
            this.SQLGroupbox.TabIndex = 14;
            this.SQLGroupbox.TabStop = false;
            this.SQLGroupbox.Text = "SQL Information";
            // 
            // SQLQueryLabel
            // 
            this.SQLQueryLabel.AutoSize = true;
            this.SQLQueryLabel.Location = new System.Drawing.Point(6, 25);
            this.SQLQueryLabel.Name = "SQLQueryLabel";
            this.SQLQueryLabel.Size = new System.Drawing.Size(59, 13);
            this.SQLQueryLabel.TabIndex = 3;
            this.SQLQueryLabel.Text = "SQL Query";
            // 
            // SQLQueryTextbox
            // 
            this.SQLQueryTextbox.Location = new System.Drawing.Point(9, 41);
            this.SQLQueryTextbox.Multiline = true;
            this.SQLQueryTextbox.Name = "SQLQueryTextbox";
            this.SQLQueryTextbox.Size = new System.Drawing.Size(376, 150);
            this.SQLQueryTextbox.TabIndex = 14;
            this.SQLQueryTextbox.Text = "SELECT TOP 1 * FROM Employees";
            // 
            // BatchSizeHelpLabel
            // 
            this.BatchSizeHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchSizeHelpLabel.Location = new System.Drawing.Point(132, 235);
            this.BatchSizeHelpLabel.Name = "BatchSizeHelpLabel";
            this.BatchSizeHelpLabel.Size = new System.Drawing.Size(262, 29);
            this.BatchSizeHelpLabel.TabIndex = 13;
            this.BatchSizeHelpLabel.Text = "If paging records, specify the number of records per page. Leave at 0 to return a" +
    "ll.";
            // 
            // PageHelpLabel
            // 
            this.PageHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageHelpLabel.Location = new System.Drawing.Point(132, 197);
            this.PageHelpLabel.Name = "PageHelpLabel";
            this.PageHelpLabel.Size = new System.Drawing.Size(262, 33);
            this.PageHelpLabel.TabIndex = 11;
            this.PageHelpLabel.Text = "If paging records, specify which page to retrieve. Otherwise, leave at 1.";
            // 
            // BatchSizeNUD
            // 
            this.BatchSizeNUD.Location = new System.Drawing.Point(67, 235);
            this.BatchSizeNUD.Name = "BatchSizeNUD";
            this.BatchSizeNUD.Size = new System.Drawing.Size(59, 20);
            this.BatchSizeNUD.TabIndex = 12;
            // 
            // PageNUD
            // 
            this.PageNUD.Location = new System.Drawing.Point(67, 197);
            this.PageNUD.Name = "PageNUD";
            this.PageNUD.Size = new System.Drawing.Size(59, 20);
            this.PageNUD.TabIndex = 11;
            this.PageNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(29, 199);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(32, 13);
            this.PageLabel.TabIndex = 8;
            this.PageLabel.Text = "Page";
            // 
            // BatchSizeLabel
            // 
            this.BatchSizeLabel.AutoSize = true;
            this.BatchSizeLabel.Location = new System.Drawing.Point(6, 237);
            this.BatchSizeLabel.Name = "BatchSizeLabel";
            this.BatchSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.BatchSizeLabel.TabIndex = 10;
            this.BatchSizeLabel.Text = "Batch Size";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(226, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(280, 20);
            this.HeaderLabel.TabIndex = 13;
            this.HeaderLabel.Text = "FetchData/SQL OODAPI Example";
            // 
            // ServerGroupbox
            // 
            this.ServerGroupbox.Controls.Add(this.URLHelpLabel);
            this.ServerGroupbox.Controls.Add(this.URLLabel);
            this.ServerGroupbox.Controls.Add(this.URLTextbox);
            this.ServerGroupbox.Location = new System.Drawing.Point(12, 47);
            this.ServerGroupbox.Name = "ServerGroupbox";
            this.ServerGroupbox.Size = new System.Drawing.Size(370, 90);
            this.ServerGroupbox.TabIndex = 12;
            this.ServerGroupbox.TabStop = false;
            this.ServerGroupbox.Text = "Server Information";
            // 
            // LoginGroupbox
            // 
            this.LoginGroupbox.Controls.Add(this.CompanyIDTextbox);
            this.LoginGroupbox.Controls.Add(this.CompanyIDLabel);
            this.LoginGroupbox.Controls.Add(this.UsernameTextbox);
            this.LoginGroupbox.Controls.Add(this.AuthenticationHelpLabel);
            this.LoginGroupbox.Controls.Add(this.UserLabel);
            this.LoginGroupbox.Controls.Add(this.APIKeyTextbox);
            this.LoginGroupbox.Controls.Add(this.label1);
            this.LoginGroupbox.Controls.Add(this.label2);
            this.LoginGroupbox.Controls.Add(this.PasswordTextbox);
            this.LoginGroupbox.Controls.Add(this.OrLabel);
            this.LoginGroupbox.Location = new System.Drawing.Point(12, 160);
            this.LoginGroupbox.Name = "LoginGroupbox";
            this.LoginGroupbox.Size = new System.Drawing.Size(370, 157);
            this.LoginGroupbox.TabIndex = 11;
            this.LoginGroupbox.TabStop = false;
            this.LoginGroupbox.Text = "Authentication";
            // 
            // CompanyIDTextbox
            // 
            this.CompanyIDTextbox.Location = new System.Drawing.Point(80, 23);
            this.CompanyIDTextbox.Name = "CompanyIDTextbox";
            this.CompanyIDTextbox.Size = new System.Drawing.Size(129, 20);
            this.CompanyIDTextbox.TabIndex = 11;
            this.CompanyIDTextbox.Text = "ODSY";
            // 
            // CompanyIDLabel
            // 
            this.CompanyIDLabel.AutoSize = true;
            this.CompanyIDLabel.Location = new System.Drawing.Point(8, 26);
            this.CompanyIDLabel.Name = "CompanyIDLabel";
            this.CompanyIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CompanyIDLabel.TabIndex = 12;
            this.CompanyIDLabel.Text = "Company ID";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(80, 49);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(129, 20);
            this.UsernameTextbox.TabIndex = 3;
            // 
            // AuthenticationHelpLabel
            // 
            this.AuthenticationHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthenticationHelpLabel.Location = new System.Drawing.Point(215, 49);
            this.AuthenticationHelpLabel.Name = "AuthenticationHelpLabel";
            this.AuthenticationHelpLabel.Size = new System.Drawing.Size(149, 54);
            this.AuthenticationHelpLabel.TabIndex = 10;
            this.AuthenticationHelpLabel.Text = "You can provide a username and password, or you can provide an APIKey.";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(18, 52);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Username";
            // 
            // APIKeyTextbox
            // 
            this.APIKeyTextbox.Location = new System.Drawing.Point(80, 114);
            this.APIKeyTextbox.Name = "APIKeyTextbox";
            this.APIKeyTextbox.Size = new System.Drawing.Size(273, 20);
            this.APIKeyTextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "API Key";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(80, 75);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(129, 20);
            this.PasswordTextbox.TabIndex = 5;
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Location = new System.Drawing.Point(77, 98);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(16, 13);
            this.OrLabel.TabIndex = 7;
            this.OrLabel.Text = "or";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.ResultsDataGridView);
            this.ResultsPanel.Controls.Add(this.ResultsHeaderPanel);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsPanel.Location = new System.Drawing.Point(0, 330);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(800, 352);
            this.ResultsPanel.TabIndex = 4;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsDataGridView.Location = new System.Drawing.Point(0, 31);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.Size = new System.Drawing.Size(800, 321);
            this.ResultsDataGridView.TabIndex = 2;
            // 
            // ResultsHeaderPanel
            // 
            this.ResultsHeaderPanel.Controls.Add(this.FindButton);
            this.ResultsHeaderPanel.Controls.Add(this.ResultsPanelLabel);
            this.ResultsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultsHeaderPanel.Name = "ResultsHeaderPanel";
            this.ResultsHeaderPanel.Size = new System.Drawing.Size(800, 31);
            this.ResultsHeaderPanel.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindButton.Location = new System.Drawing.Point(701, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(87, 23);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find       ";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ResultsPanelLabel
            // 
            this.ResultsPanelLabel.AutoSize = true;
            this.ResultsPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsPanelLabel.Location = new System.Drawing.Point(3, 8);
            this.ResultsPanelLabel.Name = "ResultsPanelLabel";
            this.ResultsPanelLabel.Size = new System.Drawing.Size(97, 13);
            this.ResultsPanelLabel.TabIndex = 0;
            this.ResultsPanelLabel.Text = "SQL Query Results";
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLForm";
            this.Text = "FetchData SQL Example (OODAPI)";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.SQLGroupbox.ResumeLayout(false);
            this.SQLGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BatchSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNUD)).EndInit();
            this.ServerGroupbox.ResumeLayout(false);
            this.ServerGroupbox.PerformLayout();
            this.LoginGroupbox.ResumeLayout(false);
            this.LoginGroupbox.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResultsHeaderPanel.ResumeLayout(false);
            this.ResultsHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Label URLHelpLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.GroupBox LoginGroupbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label AuthenticationHelpLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox APIKeyTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.GroupBox ServerGroupbox;
        private System.Windows.Forms.GroupBox SQLGroupbox;
        private System.Windows.Forms.Label BatchSizeHelpLabel;
        private System.Windows.Forms.Label PageHelpLabel;
        private System.Windows.Forms.NumericUpDown BatchSizeNUD;
        private System.Windows.Forms.NumericUpDown PageNUD;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label BatchSizeLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox SQLQueryTextbox;
        private System.Windows.Forms.Label SQLQueryLabel;
        private System.Windows.Forms.TextBox CompanyIDTextbox;
        private System.Windows.Forms.Label CompanyIDLabel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Label ResultsPanelLabel;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Panel ResultsHeaderPanel;
        private System.Windows.Forms.Button FindButton;
    }
}

