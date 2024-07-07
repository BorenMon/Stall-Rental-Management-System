using System.ComponentModel;

namespace Stall_Rental_Management_System.Views
{
    partial class FrmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddNewStall = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRentFee = new System.Windows.Forms.TextBox();
            this.dateTimeIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWaterCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxElectricCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonUpdateOrSave = new System.Windows.Forms.Button();
            this.comboBoxContractCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 64);
            this.panel1.TabIndex = 100;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::Stall_Rental_Management_System.Properties.Resources.arrow_left;
            this.buttonBack.Location = new System.Drawing.Point(14, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(27, 32);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(888, 17);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(107, 32);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonPrint);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonAddNewStall);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.dataGridViewInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 431);
            this.panel2.TabIndex = 101;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(767, 14);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(107, 31);
            this.buttonPrint.TabIndex = 70;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(129, 12);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(287, 32);
            this.textBoxSearch.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "Search Stall";
            // 
            // buttonAddNewStall
            // 
            this.buttonAddNewStall.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewStall.Location = new System.Drawing.Point(888, 14);
            this.buttonAddNewStall.Name = "buttonAddNewStall";
            this.buttonAddNewStall.Size = new System.Drawing.Size(107, 31);
            this.buttonAddNewStall.TabIndex = 64;
            this.buttonAddNewStall.Text = "Add New";
            this.buttonAddNewStall.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::Stall_Rental_Management_System.Properties.Resources.search_normal;
            this.buttonSearch.Location = new System.Drawing.Point(428, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 32);
            this.buttonSearch.TabIndex = 65;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.AllowUserToResizeColumns = false;
            this.dataGridViewInvoice.AllowUserToResizeRows = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(14, 64);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInvoice.MultiSelect = false;
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.RowHeadersWidth = 72;
            this.dataGridViewInvoice.RowTemplate.Height = 31;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(981, 351);
            this.dataGridViewInvoice.TabIndex = 69;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.comboBoxStatus);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.textBoxTotalAmount);
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.textBoxRentFee);
            this.panelDetail.Controls.Add(this.dateTimeIssuedDate);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.textBoxWaterCost);
            this.panelDetail.Controls.Add(this.label14);
            this.panelDetail.Controls.Add(this.label12);
            this.panelDetail.Controls.Add(this.textBoxElectricCost);
            this.panelDetail.Controls.Add(this.label13);
            this.panelDetail.Controls.Add(this.buttonUpdateOrSave);
            this.panelDetail.Controls.Add(this.comboBoxContractCode);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.textBoxStaffID);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.textBoxInvoiceNo);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 64);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1011, 280);
            this.panelDetail.TabIndex = 102;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(646, 120);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(349, 36);
            this.comboBoxStatus.TabIndex = 144;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 30);
            this.label7.TabIndex = 143;
            this.label7.Text = "Total Amount";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(646, 225);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(350, 32);
            this.textBoxTotalAmount.TabIndex = 142;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 141;
            this.label8.Text = "Rent Fee";
            // 
            // textBoxRentFee
            // 
            this.textBoxRentFee.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentFee.Location = new System.Drawing.Point(156, 225);
            this.textBoxRentFee.Name = "textBoxRentFee";
            this.textBoxRentFee.ReadOnly = true;
            this.textBoxRentFee.Size = new System.Drawing.Size(304, 32);
            this.textBoxRentFee.TabIndex = 140;
            // 
            // dateTimeIssuedDate
            // 
            this.dateTimeIssuedDate.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeIssuedDate.Location = new System.Drawing.Point(155, 120);
            this.dateTimeIssuedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeIssuedDate.Name = "dateTimeIssuedDate";
            this.dateTimeIssuedDate.Size = new System.Drawing.Size(304, 32);
            this.dateTimeIssuedDate.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 138;
            this.label6.Text = "Water Cost";
            // 
            // textBoxWaterCost
            // 
            this.textBoxWaterCost.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaterCost.Location = new System.Drawing.Point(645, 172);
            this.textBoxWaterCost.Name = "textBoxWaterCost";
            this.textBoxWaterCost.Size = new System.Drawing.Size(350, 32);
            this.textBoxWaterCost.TabIndex = 137;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 30);
            this.label14.TabIndex = 136;
            this.label14.Text = "Electric Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(501, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 30);
            this.label12.TabIndex = 134;
            this.label12.Text = "Status";
            // 
            // textBoxElectricCost
            // 
            this.textBoxElectricCost.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxElectricCost.Location = new System.Drawing.Point(155, 172);
            this.textBoxElectricCost.Name = "textBoxElectricCost";
            this.textBoxElectricCost.Size = new System.Drawing.Size(304, 32);
            this.textBoxElectricCost.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 30);
            this.label13.TabIndex = 132;
            this.label13.Text = "Issued Date";
            // 
            // buttonUpdateOrSave
            // 
            this.buttonUpdateOrSave.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrSave.Location = new System.Drawing.Point(888, 13);
            this.buttonUpdateOrSave.Name = "buttonUpdateOrSave";
            this.buttonUpdateOrSave.Size = new System.Drawing.Size(107, 32);
            this.buttonUpdateOrSave.TabIndex = 124;
            this.buttonUpdateOrSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxContractCode
            // 
            this.comboBoxContractCode.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContractCode.FormattingEnabled = true;
            this.comboBoxContractCode.Location = new System.Drawing.Point(645, 66);
            this.comboBoxContractCode.Name = "comboBoxContractCode";
            this.comboBoxContractCode.Size = new System.Drawing.Size(350, 36);
            this.comboBoxContractCode.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 129;
            this.label5.Text = "Contract Code";
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffID.Location = new System.Drawing.Point(155, 64);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.ReadOnly = true;
            this.textBoxStaffID.Size = new System.Drawing.Size(304, 32);
            this.textBoxStaffID.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 127;
            this.label4.Text = "Staff ID";
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(155, 13);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.ReadOnly = true;
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(304, 32);
            this.textBoxInvoiceNo.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 125;
            this.label3.Text = "Invoice No";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 775);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "FrmInvoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System / Staff Panel / Invoice Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonPrint;

        private System.Windows.Forms.ComboBox comboBoxStatus;

        private System.Windows.Forms.TextBox textBoxStaffID;

        private System.Windows.Forms.TextBox textBoxInvoiceNo;

        private System.Windows.Forms.DateTimePicker dateTimeIssuedDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRentFee;

        private System.Windows.Forms.Label label6;

        #endregion
        
        private System.Windows.Forms.TextBox textBoxWaterCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewStall;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxElectricCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUpdateOrSave;
        private System.Windows.Forms.ComboBox comboBoxContractCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}