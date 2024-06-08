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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.searchButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.contractDataGridView = new System.Windows.Forms.DataGridView();
            this.tbContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSRMSDataSet2 = new Stall_Rental_Management_System.dbSRMSDataSet2();
            this.sokphengTestContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSRMSDataSet1 = new Stall_Rental_Management_System.dbSRMSDataSet1();
            this.dbSRMSDataSet = new Stall_Rental_Management_System.dbSRMSDataSet();
            this.dbSRMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSRMSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sokphengTestContractTableAdapter = new Stall_Rental_Management_System.dbSRMSDataSet1TableAdapters.SokphengTestContractTableAdapter();
            this.dataSet1 = new Stall_Rental_Management_System.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContractTableAdapter = new Stall_Rental_Management_System.dbSRMSDataSet2TableAdapters.tbContractTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.contractUploadButton = new System.Windows.Forms.Button();
            this.staffIdComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokphengTestContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contractCodeText
            // 
            this.contractCodeText.Enabled = false;
            this.contractCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contractCodeText.Location = new System.Drawing.Point(108, 77);
            this.contractCodeText.Margin = new System.Windows.Forms.Padding(2);
            this.contractCodeText.Multiline = true;
            this.contractCodeText.Name = "contractCodeText";
            this.contractCodeText.Size = new System.Drawing.Size(268, 31);
            this.contractCodeText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stall ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startDateContract
            // 
            this.startDateContract.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startDateContract.Enabled = false;
            this.startDateContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateContract.Location = new System.Drawing.Point(108, 181);
            this.startDateContract.Margin = new System.Windows.Forms.Padding(2);
            this.startDateContract.Name = "startDateContract";
            this.startDateContract.Size = new System.Drawing.Size(268, 24);
            this.startDateContract.TabIndex = 7;
            // 
            // contractStallIDComboBox
            // 
            this.contractStallIDComboBox.Enabled = false;
            this.contractStallIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractStallIDComboBox.FormattingEnabled = true;
            this.contractStallIDComboBox.Location = new System.Drawing.Point(108, 127);
            this.contractStallIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractStallIDComboBox.Name = "contractStallIDComboBox";
            this.contractStallIDComboBox.Size = new System.Drawing.Size(268, 26);
            this.contractStallIDComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(427, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractStatusComboBox
            // 
            this.contractStatusComboBox.Enabled = false;
            this.contractStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractStatusComboBox.FormattingEnabled = true;
            this.contractStatusComboBox.Location = new System.Drawing.Point(533, 77);
            this.contractStatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractStatusComboBox.Name = "contractStatusComboBox";
            this.contractStatusComboBox.Size = new System.Drawing.Size(268, 26);
            this.contractStatusComboBox.TabIndex = 10;
            // 
            // contractVendorIDComboBox
            // 
            this.contractVendorIDComboBox.Enabled = false;
            this.contractVendorIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractVendorIDComboBox.FormattingEnabled = true;
            this.contractVendorIDComboBox.Location = new System.Drawing.Point(533, 128);
            this.contractVendorIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractVendorIDComboBox.Name = "contractVendorIDComboBox";
            this.contractVendorIDComboBox.Size = new System.Drawing.Size(268, 26);
            this.contractVendorIDComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vendor ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endDateConstract
            // 
            this.endDateConstract.Enabled = false;
            this.endDateConstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateConstract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateConstract.Location = new System.Drawing.Point(533, 179);
            this.endDateConstract.Margin = new System.Windows.Forms.Padding(2);
            this.endDateConstract.Name = "endDateConstract";
            this.endDateConstract.Size = new System.Drawing.Size(268, 24);
            this.endDateConstract.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "End Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractSearchTextBox
            // 
            this.contractSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractSearchTextBox.Location = new System.Drawing.Point(108, 281);
            this.contractSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractSearchTextBox.Multiline = true;
            this.contractSearchTextBox.Name = "contractSearchTextBox";
            this.contractSearchTextBox.Size = new System.Drawing.Size(268, 31);
            this.contractSearchTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(17, 281);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 32);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.newButton.Location = new System.Drawing.Point(431, 281);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(77, 32);
            this.newButton.TabIndex = 17;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(524, 281);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 32);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(605, 281);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 32);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.Location = new System.Drawing.Point(699, 280);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(2);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(101, 32);
            this.downloadButton.TabIndex = 20;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // contractDataGridView
            // 
            this.contractDataGridView.AllowUserToAddRows = false;
            this.contractDataGridView.AllowUserToDeleteRows = false;
            this.contractDataGridView.AllowUserToResizeColumns = false;
            this.contractDataGridView.AllowUserToResizeRows = false;
            this.contractDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contractDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contractDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.contractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contractDataGridView.Location = new System.Drawing.Point(18, 333);
            this.contractDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.contractDataGridView.Name = "contractDataGridView";
            this.contractDataGridView.ReadOnly = true;
            this.contractDataGridView.RowHeadersWidth = 62;
            this.contractDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contractDataGridView.RowTemplate.Height = 28;
            this.contractDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractDataGridView.Size = new System.Drawing.Size(783, 229);
            this.contractDataGridView.TabIndex = 21;
            this.contractDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractDataGridView_CellClick);
            // 
            // tbContractBindingSource
            // 
            this.tbContractBindingSource.DataMember = "tbContract";
            this.tbContractBindingSource.DataSource = this.dbSRMSDataSet2;
            // 
            // dbSRMSDataSet2
            // 
            this.dbSRMSDataSet2.DataSetName = "dbSRMSDataSet2";
            this.dbSRMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sokphengTestContractBindingSource
            // 
            this.sokphengTestContractBindingSource.DataMember = "SokphengTestContract";
            this.sokphengTestContractBindingSource.DataSource = this.dbSRMSDataSet1;
            // 
            // dbSRMSDataSet1
            // 
            this.dbSRMSDataSet1.DataSetName = "dbSRMSDataSet1";
            this.dbSRMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sokphengTestContractTableAdapter
            // 
            this.sokphengTestContractTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // tbContractTableAdapter
            // 
            this.tbContractTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract Management";
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(701, 19);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 32);
            this.logoutButton.TabIndex = 22;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "File: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractUploadButton
            // 
            this.contractUploadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contractUploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contractUploadButton.Enabled = false;
            this.contractUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractUploadButton.Location = new System.Drawing.Point(108, 227);
            this.contractUploadButton.Margin = new System.Windows.Forms.Padding(2);
            this.contractUploadButton.Name = "contractUploadButton";
            this.contractUploadButton.Size = new System.Drawing.Size(205, 32);
            this.contractUploadButton.TabIndex = 24;
            this.contractUploadButton.Text = "Upload Contract File";
            this.contractUploadButton.UseVisualStyleBackColor = false;
            this.contractUploadButton.Click += new System.EventHandler(this.contractUploadButton_Click);
            // 
            // staffIdComboBox
            // 
            this.staffIdComboBox.Enabled = false;
            this.staffIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.staffIdComboBox.FormattingEnabled = true;
            this.staffIdComboBox.Location = new System.Drawing.Point(533, 226);
            this.staffIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.staffIdComboBox.Name = "staffIdComboBox";
            this.staffIdComboBox.Size = new System.Drawing.Size(268, 26);
            this.staffIdComboBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(427, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Staff ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.previousButton.Image = global::Stall_Rental_Management_System.Properties.Resources.previouos_icon_16x16;
            this.previousButton.Location = new System.Drawing.Point(17, 21);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(27, 31);
            this.previousButton.TabIndex = 0;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.staffIdComboBox);
            this.Controls.Add(this.contractUploadButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.contractDataGridView);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmContract";
            this.Text = "Stall Rental Management System";
            this.Load += new System.EventHandler(this.FrmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokphengTestContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSRMSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView contractDataGridView;
        private System.Windows.Forms.BindingSource dbSRMSDataSetBindingSource;
        private dbSRMSDataSet dbSRMSDataSet;
        private System.Windows.Forms.BindingSource dbSRMSDataSetBindingSource1;
        private dbSRMSDataSet1 dbSRMSDataSet1;
        private System.Windows.Forms.BindingSource sokphengTestContractBindingSource;
        private dbSRMSDataSet1TableAdapters.SokphengTestContractTableAdapter sokphengTestContractTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private dbSRMSDataSet2 dbSRMSDataSet2;
        private System.Windows.Forms.BindingSource tbContractBindingSource;
        private dbSRMSDataSet2TableAdapters.tbContractTableAdapter tbContractTableAdapter;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button contractUploadButton;
        private System.Windows.Forms.ComboBox staffIdComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}