namespace Stall_Rental_Management_System.Views.InvoiceForm
{
    partial class FrmInvoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxStaffID = new System.Windows.Forms.ComboBox();
            this.ComboBoxContractID = new System.Windows.Forms.ComboBox();
            this.txtIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtRentFee = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtWaterCost = new System.Windows.Forms.TextBox();
            this.txtElectricityCost = new System.Windows.Forms.TextBox();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.txtInvoiceNO = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceFileURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Electricity_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Water_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent_Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ComboBoxStaffID);
            this.panel1.Controls.Add(this.ComboBoxContractID);
            this.panel1.Controls.Add(this.txtIssuedDate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtRentFee);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.txtWaterCost);
            this.panel1.Controls.Add(this.txtElectricityCost);
            this.panel1.Controls.Add(this.txtFileURL);
            this.panel1.Controls.Add(this.txtInvoiceNO);
            this.panel1.Controls.Add(this.txtInvoiceID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 607);
            this.panel1.TabIndex = 0;
            // 
            // ComboBoxStaffID
            // 
            this.ComboBoxStaffID.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStaffID.FormattingEnabled = true;
            this.ComboBoxStaffID.Location = new System.Drawing.Point(224, 344);
            this.ComboBoxStaffID.Name = "ComboBoxStaffID";
            this.ComboBoxStaffID.Size = new System.Drawing.Size(257, 34);
            this.ComboBoxStaffID.TabIndex = 9;
            this.ComboBoxStaffID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStaffID_SelectedIndexChanged);
            // 
            // ComboBoxContractID
            // 
            this.ComboBoxContractID.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxContractID.FormattingEnabled = true;
            this.ComboBoxContractID.Location = new System.Drawing.Point(224, 294);
            this.ComboBoxContractID.Name = "ComboBoxContractID";
            this.ComboBoxContractID.Size = new System.Drawing.Size(257, 34);
            this.ComboBoxContractID.TabIndex = 9;
            this.ComboBoxContractID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxContractID_SelectedIndexChanged);
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtIssuedDate.Location = new System.Drawing.Point(224, 250);
            this.txtIssuedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(257, 26);
            this.txtIssuedDate.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 207;
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "REAIL",
            "USD",
            "BAHT",
            "VET"});
            this.comboBox1.Location = new System.Drawing.Point(224, 449);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 34);
            this.comboBox1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 34);
            this.label11.TabIndex = 1;
            this.label11.Text = "Currency";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "Status ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 34);
            this.label10.TabIndex = 1;
            this.label10.Text = "Rent Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 34);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "StaffID   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "ContractID ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "IssuedDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Water Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Electricity Cost ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "InvoiceFileURL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 34);
            this.label13.TabIndex = 1;
            this.label13.Text = "InvoiceNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "InvoiceID";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(224, 397);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(257, 29);
            this.txtStatus.TabIndex = 0;
            // 
            // txtRentFee
            // 
            this.txtRentFee.Location = new System.Drawing.Point(224, 545);
            this.txtRentFee.Multiline = true;
            this.txtRentFee.Name = "txtRentFee";
            this.txtRentFee.Size = new System.Drawing.Size(257, 29);
            this.txtRentFee.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(224, 499);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(257, 29);
            this.txtTotalAmount.TabIndex = 0;
            // 
            // txtWaterCost
            // 
            this.txtWaterCost.Location = new System.Drawing.Point(224, 197);
            this.txtWaterCost.Multiline = true;
            this.txtWaterCost.Name = "txtWaterCost";
            this.txtWaterCost.Size = new System.Drawing.Size(257, 29);
            this.txtWaterCost.TabIndex = 0;
            // 
            // txtElectricityCost
            // 
            this.txtElectricityCost.Location = new System.Drawing.Point(224, 144);
            this.txtElectricityCost.Multiline = true;
            this.txtElectricityCost.Name = "txtElectricityCost";
            this.txtElectricityCost.Size = new System.Drawing.Size(257, 29);
            this.txtElectricityCost.TabIndex = 0;
            // 
            // txtFileURL
            // 
            this.txtFileURL.Location = new System.Drawing.Point(224, 99);
            this.txtFileURL.Multiline = true;
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.Size = new System.Drawing.Size(257, 29);
            this.txtFileURL.TabIndex = 0;
            // 
            // txtInvoiceNO
            // 
            this.txtInvoiceNO.Location = new System.Drawing.Point(224, 52);
            this.txtInvoiceNO.Multiline = true;
            this.txtInvoiceNO.Name = "txtInvoiceNO";
            this.txtInvoiceNO.Size = new System.Drawing.Size(257, 29);
            this.txtInvoiceNO.TabIndex = 0;
            this.txtInvoiceNO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.CausesValidation = false;
            this.txtInvoiceID.Location = new System.Drawing.Point(224, 8);
            this.txtInvoiceID.Multiline = true;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(257, 29);
            this.txtInvoiceID.TabIndex = 0;
            this.txtInvoiceID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(572, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 607);
            this.panel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 34);
            this.label12.TabIndex = 3;
            this.label12.Text = "Search";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 26);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.InvoiceFileURL,
            this.Electricity_Cost,
            this.Water_Cost,
            this.InvoiceDate,
            this.ContractID,
            this.StaffID,
            this.Currency,
            this.Total_Amount,
            this.Rent_Fee});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 519);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            // 
            // InvoiceFileURL
            // 
            this.InvoiceFileURL.HeaderText = "InvoiceFileURL";
            this.InvoiceFileURL.Name = "InvoiceFileURL";
            // 
            // Electricity_Cost
            // 
            this.Electricity_Cost.HeaderText = "Electricity_Cost";
            this.Electricity_Cost.Name = "Electricity_Cost";
            // 
            // Water_Cost
            // 
            this.Water_Cost.HeaderText = "Water_Cost";
            this.Water_Cost.Name = "Water_Cost";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "InvoiceDate";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // ContractID
            // 
            this.ContractID.HeaderText = "ContractID";
            this.ContractID.Name = "ContractID";
            // 
            // StaffID
            // 
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total_Amount";
            this.Total_Amount.Name = "Total_Amount";
            // 
            // Rent_Fee
            // 
            this.Rent_Fee.HeaderText = "Rent_Fee";
            this.Rent_Fee.Name = "Rent_Fee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(1110, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 607);
            this.panel3.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(3, 542);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(123, 50);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmInvoice1
            // 
            this.AccessibleName = "FrmInvoice1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice1";
            this.Load += new System.EventHandler(this.FrmInvoice1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtRentFee;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtWaterCost;
        private System.Windows.Forms.TextBox txtElectricityCost;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFileURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Electricity_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Water_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent_Fee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInvoiceNO;
        private System.Windows.Forms.DateTimePicker txtIssuedDate;
        private System.Windows.Forms.ComboBox ComboBoxStaffID;
        private System.Windows.Forms.ComboBox ComboBoxContractID;
    }
}