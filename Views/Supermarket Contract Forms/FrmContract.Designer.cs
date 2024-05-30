namespace Stall_Rental_Management_System.Views.Supermarket_Contract_Forms
{
    partial class FrmContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.contractCodeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDateContract = new System.Windows.Forms.DateTimePicker();
            this.contractStallIDComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contractStatusComboBox = new System.Windows.Forms.ComboBox();
            this.contractVendorIDComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endDateConstract = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.contractSearchTextBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            this.dbSRMSDataSet = new Stall_Rental_Management_System.dbSRMSDataSet();
            this.dbSRMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSRMSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSRMSDataSet1 = new Stall_Rental_Management_System.dbSRMSDataSet1();
            this.sokphengTestContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sokphengTestContractTableAdapter = new Stall_Rental_Management_System.dbSRMSDataSet1TableAdapters.SokphengTestContractTableAdapter();
            this.contractCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokphengTestContractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract Management";
            // 
            // contractCodeText
            // 
            this.contractCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractCodeText.Location = new System.Drawing.Point(162, 118);
            this.contractCodeText.Multiline = true;
            this.contractCodeText.Name = "contractCodeText";
            this.contractCodeText.Size = new System.Drawing.Size(400, 45);
            this.contractCodeText.TabIndex = 2;
            this.contractCodeText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stall ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startDateContract
            // 
            this.startDateContract.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startDateContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startDateContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateContract.Location = new System.Drawing.Point(162, 267);
            this.startDateContract.Name = "startDateContract";
            this.startDateContract.Size = new System.Drawing.Size(400, 35);
            this.startDateContract.TabIndex = 7;
            this.startDateContract.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // contractStallIDComboBox
            // 
            this.contractStallIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractStallIDComboBox.FormattingEnabled = true;
            this.contractStallIDComboBox.Location = new System.Drawing.Point(162, 196);
            this.contractStallIDComboBox.Name = "contractStallIDComboBox";
            this.contractStallIDComboBox.Size = new System.Drawing.Size(400, 37);
            this.contractStallIDComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractStatusComboBox
            // 
            this.contractStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractStatusComboBox.FormattingEnabled = true;
            this.contractStatusComboBox.Location = new System.Drawing.Point(800, 119);
            this.contractStatusComboBox.Name = "contractStatusComboBox";
            this.contractStatusComboBox.Size = new System.Drawing.Size(400, 37);
            this.contractStatusComboBox.TabIndex = 10;
            // 
            // contractVendorIDComboBox
            // 
            this.contractVendorIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractVendorIDComboBox.FormattingEnabled = true;
            this.contractVendorIDComboBox.Location = new System.Drawing.Point(800, 194);
            this.contractVendorIDComboBox.Name = "contractVendorIDComboBox";
            this.contractVendorIDComboBox.Size = new System.Drawing.Size(400, 37);
            this.contractVendorIDComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vendor ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endDateConstract
            // 
            this.endDateConstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endDateConstract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateConstract.Location = new System.Drawing.Point(800, 268);
            this.endDateConstract.Name = "endDateConstract";
            this.endDateConstract.Size = new System.Drawing.Size(400, 35);
            this.endDateConstract.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "End Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractSearchTextBox
            // 
            this.contractSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractSearchTextBox.Location = new System.Drawing.Point(162, 336);
            this.contractSearchTextBox.Multiline = true;
            this.contractSearchTextBox.Name = "contractSearchTextBox";
            this.contractSearchTextBox.Size = new System.Drawing.Size(400, 45);
            this.contractSearchTextBox.TabIndex = 15;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.previousButton.Image = global::Stall_Rental_Management_System.Properties.Resources.previouos_icon_16x16;
            this.previousButton.Location = new System.Drawing.Point(26, 32);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(40, 47);
            this.previousButton.TabIndex = 0;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.Location = new System.Drawing.Point(26, 339);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 45);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newButton.Location = new System.Drawing.Point(657, 336);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 45);
            this.newButton.TabIndex = 17;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(800, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateButton.Location = new System.Drawing.Point(938, 336);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 45);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.downloadButton.Location = new System.Drawing.Point(1077, 334);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(123, 45);
            this.downloadButton.TabIndex = 20;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.stallIDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sokphengTestContractBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 353);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(1100, 32);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 45);
            this.logoutButton.TabIndex = 22;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // dbSRMSDataSet
            // 
            this.dbSRMSDataSet.DataSetName = "dbSRMSDataSet";
            this.dbSRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSRMSDataSetBindingSource
            // 
            this.dbSRMSDataSetBindingSource.DataSource = this.dbSRMSDataSet;
            this.dbSRMSDataSetBindingSource.Position = 0;
            // 
            // dbSRMSDataSetBindingSource1
            // 
            this.dbSRMSDataSetBindingSource1.DataSource = this.dbSRMSDataSet;
            this.dbSRMSDataSetBindingSource1.Position = 0;
            // 
            // dbSRMSDataSet1
            // 
            this.dbSRMSDataSet1.DataSetName = "dbSRMSDataSet1";
            this.dbSRMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sokphengTestContractBindingSource
            // 
            this.sokphengTestContractBindingSource.DataMember = "SokphengTestContract";
            this.sokphengTestContractBindingSource.DataSource = this.dbSRMSDataSet1;
            // 
            // sokphengTestContractTableAdapter
            // 
            this.sokphengTestContractTableAdapter.ClearBeforeFill = true;
            // 
            // contractCodeDataGridViewTextBoxColumn
            // 
            this.contractCodeDataGridViewTextBoxColumn.DataPropertyName = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.HeaderText = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contractCodeDataGridViewTextBoxColumn.Name = "contractCodeDataGridViewTextBoxColumn";
            this.contractCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // stallIDDataGridViewTextBoxColumn
            // 
            this.stallIDDataGridViewTextBoxColumn.DataPropertyName = "StallID";
            this.stallIDDataGridViewTextBoxColumn.HeaderText = "StallID";
            this.stallIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stallIDDataGridViewTextBoxColumn.Name = "stallIDDataGridViewTextBoxColumn";
            this.stallIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stallIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 794);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.contractSearchTextBox);
            this.Controls.Add(this.endDateConstract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contractVendorIDComboBox);
            this.Controls.Add(this.contractStatusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contractStallIDComboBox);
            this.Controls.Add(this.startDateContract);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractCodeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FrmContract";
            this.Text = "Stall Rental Management System";
            this.Load += new System.EventHandler(this.FrmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokphengTestContractBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractCodeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDateContract;
        private System.Windows.Forms.ComboBox contractStallIDComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox contractStatusComboBox;
        private System.Windows.Forms.ComboBox contractVendorIDComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDateConstract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contractSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.BindingSource dbSRMSDataSetBindingSource;
        private dbSRMSDataSet dbSRMSDataSet;
        private System.Windows.Forms.BindingSource dbSRMSDataSetBindingSource1;
        private dbSRMSDataSet1 dbSRMSDataSet1;
        private System.Windows.Forms.BindingSource sokphengTestContractBindingSource;
        private dbSRMSDataSet1TableAdapters.SokphengTestContractTableAdapter sokphengTestContractTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}