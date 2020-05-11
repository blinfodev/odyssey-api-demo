namespace JsonDocumentCreator
{
    partial class JsonCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonCreatorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.connectionGroupbox = new System.Windows.Forms.GroupBox();
            this.APIKeyTextbox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.CompanyIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataViewTabPage = new System.Windows.Forms.TabPage();
            this.GenerateDataViewDocument = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Param3FieldName = new System.Windows.Forms.TextBox();
            this.Param3Operator = new System.Windows.Forms.ComboBox();
            this.Param3Value = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Param2FieldName = new System.Windows.Forms.TextBox();
            this.Param2Operator = new System.Windows.Forms.ComboBox();
            this.Param2Value = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Param1FieldName = new System.Windows.Forms.TextBox();
            this.Param1Operator = new System.Windows.Forms.ComboBox();
            this.Param1Value = new System.Windows.Forms.TextBox();
            this.DataViewNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlTabPage = new System.Windows.Forms.TabPage();
            this.SQLTableName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SQlGenerateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SQLQueryTextbox = new System.Windows.Forms.TextBox();
            this.ablTabPage = new System.Windows.Forms.TabPage();
            this.FieldListTextbox = new System.Windows.Forms.Label();
            this.ABLFieldListTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ABLSortTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ABLTableNameTextbox = new System.Windows.Forms.TextBox();
            this.GenerateABLButton = new System.Windows.Forms.Button();
            this.ablQueryButton = new System.Windows.Forms.Label();
            this.ABLQueryTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.connectionGroupbox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dataViewTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sqlTabPage.SuspendLayout();
            this.ablTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnClickExitMenu);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnClickAboutMenu);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(110, 19);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(208, 20);
            this.URLTextBox.TabIndex = 1;
            this.URLTextBox.Text = "https://api.blinfo.com/company";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(9, 22);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(95, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "Odyssey API URL:";
            // 
            // connectionGroupbox
            // 
            this.connectionGroupbox.Controls.Add(this.APIKeyTextbox);
            this.connectionGroupbox.Controls.Add(this.apiKeyLabel);
            this.connectionGroupbox.Controls.Add(this.CompanyIDTextbox);
            this.connectionGroupbox.Controls.Add(this.label1);
            this.connectionGroupbox.Controls.Add(this.URLTextBox);
            this.connectionGroupbox.Controls.Add(this.urlLabel);
            this.connectionGroupbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionGroupbox.Location = new System.Drawing.Point(0, 24);
            this.connectionGroupbox.Name = "connectionGroupbox";
            this.connectionGroupbox.Size = new System.Drawing.Size(800, 48);
            this.connectionGroupbox.TabIndex = 3;
            this.connectionGroupbox.TabStop = false;
            this.connectionGroupbox.Text = "Connection Information";
            // 
            // APIKeyTextbox
            // 
            this.APIKeyTextbox.Location = new System.Drawing.Point(541, 19);
            this.APIKeyTextbox.Name = "APIKeyTextbox";
            this.APIKeyTextbox.Size = new System.Drawing.Size(143, 20);
            this.APIKeyTextbox.TabIndex = 5;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(487, 22);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(48, 13);
            this.apiKeyLabel.TabIndex = 6;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // CompanyIDTextbox
            // 
            this.CompanyIDTextbox.Location = new System.Drawing.Point(398, 19);
            this.CompanyIDTextbox.Name = "CompanyIDTextbox";
            this.CompanyIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.CompanyIDTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataViewTabPage);
            this.tabControl1.Controls.Add(this.sqlTabPage);
            this.tabControl1.Controls.Add(this.ablTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 280);
            this.tabControl1.TabIndex = 4;
            // 
            // dataViewTabPage
            // 
            this.dataViewTabPage.Controls.Add(this.GenerateDataViewDocument);
            this.dataViewTabPage.Controls.Add(this.groupBox3);
            this.dataViewTabPage.Controls.Add(this.groupBox2);
            this.dataViewTabPage.Controls.Add(this.groupBox1);
            this.dataViewTabPage.Controls.Add(this.DataViewNameTextbox);
            this.dataViewTabPage.Controls.Add(this.label2);
            this.dataViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataViewTabPage.Name = "dataViewTabPage";
            this.dataViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTabPage.Size = new System.Drawing.Size(792, 254);
            this.dataViewTabPage.TabIndex = 0;
            this.dataViewTabPage.Text = "Data View";
            this.dataViewTabPage.UseVisualStyleBackColor = true;
            // 
            // GenerateDataViewDocument
            // 
            this.GenerateDataViewDocument.Location = new System.Drawing.Point(316, 225);
            this.GenerateDataViewDocument.Name = "GenerateDataViewDocument";
            this.GenerateDataViewDocument.Size = new System.Drawing.Size(110, 23);
            this.GenerateDataViewDocument.TabIndex = 16;
            this.GenerateDataViewDocument.Text = "Generate JSON";
            this.GenerateDataViewDocument.UseVisualStyleBackColor = true;
            this.GenerateDataViewDocument.Click += new System.EventHandler(this.GenerateDataViewDocument_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Param3FieldName);
            this.groupBox3.Controls.Add(this.Param3Operator);
            this.groupBox3.Controls.Add(this.Param3Value);
            this.groupBox3.Location = new System.Drawing.Point(8, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 59);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Field:";
            // 
            // Param3FieldName
            // 
            this.Param3FieldName.Location = new System.Drawing.Point(44, 18);
            this.Param3FieldName.Name = "Param3FieldName";
            this.Param3FieldName.Size = new System.Drawing.Size(135, 20);
            this.Param3FieldName.TabIndex = 12;
            // 
            // Param3Operator
            // 
            this.Param3Operator.FormattingEnabled = true;
            this.Param3Operator.Items.AddRange(new object[] {
            "=",
            ">=",
            "<="});
            this.Param3Operator.Location = new System.Drawing.Point(185, 17);
            this.Param3Operator.Name = "Param3Operator";
            this.Param3Operator.Size = new System.Drawing.Size(66, 21);
            this.Param3Operator.TabIndex = 11;
            this.Param3Operator.Text = "=";
            // 
            // Param3Value
            // 
            this.Param3Value.Location = new System.Drawing.Point(257, 18);
            this.Param3Value.Name = "Param3Value";
            this.Param3Value.Size = new System.Drawing.Size(136, 20);
            this.Param3Value.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Param2FieldName);
            this.groupBox2.Controls.Add(this.Param2Operator);
            this.groupBox2.Controls.Add(this.Param2Value);
            this.groupBox2.Location = new System.Drawing.Point(8, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 59);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Field:";
            // 
            // Param2FieldName
            // 
            this.Param2FieldName.Location = new System.Drawing.Point(44, 18);
            this.Param2FieldName.Name = "Param2FieldName";
            this.Param2FieldName.Size = new System.Drawing.Size(135, 20);
            this.Param2FieldName.TabIndex = 12;
            // 
            // Param2Operator
            // 
            this.Param2Operator.FormattingEnabled = true;
            this.Param2Operator.Items.AddRange(new object[] {
            "=",
            ">=",
            "<="});
            this.Param2Operator.Location = new System.Drawing.Point(185, 17);
            this.Param2Operator.Name = "Param2Operator";
            this.Param2Operator.Size = new System.Drawing.Size(66, 21);
            this.Param2Operator.TabIndex = 11;
            this.Param2Operator.Text = "=";
            // 
            // Param2Value
            // 
            this.Param2Value.Location = new System.Drawing.Point(257, 18);
            this.Param2Value.Name = "Param2Value";
            this.Param2Value.Size = new System.Drawing.Size(136, 20);
            this.Param2Value.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Param1FieldName);
            this.groupBox1.Controls.Add(this.Param1Operator);
            this.groupBox1.Controls.Add(this.Param1Value);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Field:";
            // 
            // Param1FieldName
            // 
            this.Param1FieldName.Location = new System.Drawing.Point(44, 18);
            this.Param1FieldName.Name = "Param1FieldName";
            this.Param1FieldName.Size = new System.Drawing.Size(135, 20);
            this.Param1FieldName.TabIndex = 12;
            // 
            // Param1Operator
            // 
            this.Param1Operator.FormattingEnabled = true;
            this.Param1Operator.Items.AddRange(new object[] {
            "=",
            ">=",
            "<="});
            this.Param1Operator.Location = new System.Drawing.Point(185, 17);
            this.Param1Operator.Name = "Param1Operator";
            this.Param1Operator.Size = new System.Drawing.Size(66, 21);
            this.Param1Operator.TabIndex = 11;
            this.Param1Operator.Text = "=";
            // 
            // Param1Value
            // 
            this.Param1Value.Location = new System.Drawing.Point(257, 18);
            this.Param1Value.Name = "Param1Value";
            this.Param1Value.Size = new System.Drawing.Size(136, 20);
            this.Param1Value.TabIndex = 10;
            // 
            // DataViewNameTextbox
            // 
            this.DataViewNameTextbox.Location = new System.Drawing.Point(101, 6);
            this.DataViewNameTextbox.Name = "DataViewNameTextbox";
            this.DataViewNameTextbox.Size = new System.Drawing.Size(208, 20);
            this.DataViewNameTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data View Name:";
            // 
            // sqlTabPage
            // 
            this.sqlTabPage.Controls.Add(this.SQLTableName);
            this.sqlTabPage.Controls.Add(this.label9);
            this.sqlTabPage.Controls.Add(this.SQlGenerateButton);
            this.sqlTabPage.Controls.Add(this.label3);
            this.sqlTabPage.Controls.Add(this.SQLQueryTextbox);
            this.sqlTabPage.Location = new System.Drawing.Point(4, 22);
            this.sqlTabPage.Name = "sqlTabPage";
            this.sqlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sqlTabPage.Size = new System.Drawing.Size(792, 254);
            this.sqlTabPage.TabIndex = 1;
            this.sqlTabPage.Text = "SQL";
            this.sqlTabPage.UseVisualStyleBackColor = true;
            // 
            // SQLTableName
            // 
            this.SQLTableName.Location = new System.Drawing.Point(73, 10);
            this.SQLTableName.Name = "SQLTableName";
            this.SQLTableName.Size = new System.Drawing.Size(222, 20);
            this.SQLTableName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Table Name";
            // 
            // SQlGenerateButton
            // 
            this.SQlGenerateButton.Location = new System.Drawing.Point(185, 223);
            this.SQlGenerateButton.Name = "SQlGenerateButton";
            this.SQlGenerateButton.Size = new System.Drawing.Size(110, 23);
            this.SQlGenerateButton.TabIndex = 8;
            this.SQlGenerateButton.Text = "Generate JSON";
            this.SQlGenerateButton.UseVisualStyleBackColor = true;
            this.SQlGenerateButton.Click += new System.EventHandler(this.SQlGenerateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SQL Query";
            // 
            // SQLQueryTextbox
            // 
            this.SQLQueryTextbox.Location = new System.Drawing.Point(73, 37);
            this.SQLQueryTextbox.Multiline = true;
            this.SQLQueryTextbox.Name = "SQLQueryTextbox";
            this.SQLQueryTextbox.Size = new System.Drawing.Size(222, 180);
            this.SQLQueryTextbox.TabIndex = 0;
            // 
            // ablTabPage
            // 
            this.ablTabPage.Controls.Add(this.FieldListTextbox);
            this.ablTabPage.Controls.Add(this.ABLFieldListTextbox);
            this.ablTabPage.Controls.Add(this.label5);
            this.ablTabPage.Controls.Add(this.ABLSortTextbox);
            this.ablTabPage.Controls.Add(this.label4);
            this.ablTabPage.Controls.Add(this.ABLTableNameTextbox);
            this.ablTabPage.Controls.Add(this.GenerateABLButton);
            this.ablTabPage.Controls.Add(this.ablQueryButton);
            this.ablTabPage.Controls.Add(this.ABLQueryTextbox);
            this.ablTabPage.Location = new System.Drawing.Point(4, 22);
            this.ablTabPage.Name = "ablTabPage";
            this.ablTabPage.Size = new System.Drawing.Size(792, 254);
            this.ablTabPage.TabIndex = 2;
            this.ablTabPage.Text = "ABL";
            this.ablTabPage.UseVisualStyleBackColor = true;
            // 
            // FieldListTextbox
            // 
            this.FieldListTextbox.AutoSize = true;
            this.FieldListTextbox.Location = new System.Drawing.Point(25, 95);
            this.FieldListTextbox.Name = "FieldListTextbox";
            this.FieldListTextbox.Size = new System.Drawing.Size(51, 13);
            this.FieldListTextbox.TabIndex = 17;
            this.FieldListTextbox.Text = "Field List:";
            // 
            // ABLFieldListTextbox
            // 
            this.ABLFieldListTextbox.Location = new System.Drawing.Point(82, 92);
            this.ABLFieldListTextbox.Name = "ABLFieldListTextbox";
            this.ABLFieldListTextbox.Size = new System.Drawing.Size(222, 20);
            this.ABLFieldListTextbox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sort:";
            // 
            // ABLSortTextbox
            // 
            this.ABLSortTextbox.Location = new System.Drawing.Point(82, 66);
            this.ABLSortTextbox.Name = "ABLSortTextbox";
            this.ABLSortTextbox.Size = new System.Drawing.Size(222, 20);
            this.ABLSortTextbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Table Name:";
            // 
            // ABLTableNameTextbox
            // 
            this.ABLTableNameTextbox.Location = new System.Drawing.Point(82, 14);
            this.ABLTableNameTextbox.Name = "ABLTableNameTextbox";
            this.ABLTableNameTextbox.Size = new System.Drawing.Size(222, 20);
            this.ABLTableNameTextbox.TabIndex = 12;
            // 
            // GenerateABLButton
            // 
            this.GenerateABLButton.Location = new System.Drawing.Point(194, 118);
            this.GenerateABLButton.Name = "GenerateABLButton";
            this.GenerateABLButton.Size = new System.Drawing.Size(110, 23);
            this.GenerateABLButton.TabIndex = 11;
            this.GenerateABLButton.Text = "Generate JSON";
            this.GenerateABLButton.UseVisualStyleBackColor = true;
            this.GenerateABLButton.Click += new System.EventHandler(this.GenerateABLButton_Click);
            // 
            // ablQueryButton
            // 
            this.ablQueryButton.AutoSize = true;
            this.ablQueryButton.Location = new System.Drawing.Point(18, 43);
            this.ablQueryButton.Name = "ablQueryButton";
            this.ablQueryButton.Size = new System.Drawing.Size(61, 13);
            this.ablQueryButton.TabIndex = 10;
            this.ablQueryButton.Text = "ABL Query:";
            // 
            // ABLQueryTextbox
            // 
            this.ABLQueryTextbox.Location = new System.Drawing.Point(82, 40);
            this.ABLQueryTextbox.Name = "ABLQueryTextbox";
            this.ABLQueryTextbox.Size = new System.Drawing.Size(222, 20);
            this.ABLQueryTextbox.TabIndex = 9;
            this.ABLQueryTextbox.Text = "1=1";
            // 
            // JsonCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.connectionGroupbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JsonCreatorForm";
            this.Text = "Json Document Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.connectionGroupbox.ResumeLayout(false);
            this.connectionGroupbox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.dataViewTabPage.ResumeLayout(false);
            this.dataViewTabPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sqlTabPage.ResumeLayout(false);
            this.sqlTabPage.PerformLayout();
            this.ablTabPage.ResumeLayout(false);
            this.ablTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.GroupBox connectionGroupbox;
        private System.Windows.Forms.TextBox APIKeyTextbox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox CompanyIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dataViewTabPage;
        private System.Windows.Forms.TabPage sqlTabPage;
        private System.Windows.Forms.TextBox DataViewNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ablTabPage;
        private System.Windows.Forms.Button SQlGenerateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SQLQueryTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ABLSortTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ABLTableNameTextbox;
        private System.Windows.Forms.Button GenerateABLButton;
        private System.Windows.Forms.Label ablQueryButton;
        private System.Windows.Forms.TextBox ABLQueryTextbox;
        private System.Windows.Forms.Label FieldListTextbox;
        private System.Windows.Forms.TextBox ABLFieldListTextbox;
        private System.Windows.Forms.ComboBox Param1Operator;
        private System.Windows.Forms.TextBox Param1Value;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Param3FieldName;
        private System.Windows.Forms.ComboBox Param3Operator;
        private System.Windows.Forms.TextBox Param3Value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Param2FieldName;
        private System.Windows.Forms.ComboBox Param2Operator;
        private System.Windows.Forms.TextBox Param2Value;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Param1FieldName;
        private System.Windows.Forms.Button GenerateDataViewDocument;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SQLTableName;
    }
}

