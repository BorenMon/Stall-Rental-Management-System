namespace Stall_Rental_Management_System.Views
{
    partial class FrmPayment
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceNoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentReferenceDataGrid = new System.Windows.Forms.DataGridView();
            this.addPaymentReferenceButton = new System.Windows.Forms.Button();
            this.referencePictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchPaymentTextBox = new System.Windows.Forms.TextBox();
            this.SeachButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.previousButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentReferenceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(1053, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 50);
            this.logoutButton.TabIndex = 28;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 56);
            this.label1.TabIndex = 27;
            this.label1.Text = "Payment Management";
            // 
            // invoiceNoComboBox
            // 
            this.invoiceNoComboBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.invoiceNoComboBox.FormattingEnabled = true;
            this.invoiceNoComboBox.Location = new System.Drawing.Point(230, 113);
            this.invoiceNoComboBox.Name = "invoiceNoComboBox";
            this.invoiceNoComboBox.Size = new System.Drawing.Size(352, 50);
            this.invoiceNoComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 42);
            this.label2.TabIndex = 30;
            this.label2.Text = "Invoice No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 42);
            this.label3.TabIndex = 32;
            this.label3.Text = "Payment Method:";
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Location = new System.Drawing.Point(862, 116);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(341, 50);
            this.paymentMethodComboBox.TabIndex = 31;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(862, 204);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(341, 50);
            this.statusComboBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 42);
            this.label4.TabIndex = 34;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 42);
            this.label5.TabIndex = 36;
            this.label5.Text = "Currency:";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(862, 291);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(341, 50);
            this.currencyComboBox.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.paymentReferenceDataGrid);
            this.panel1.Controls.Add(this.addPaymentReferenceButton);
            this.panel1.Controls.Add(this.referencePictureBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(28, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 384);
            this.panel1.TabIndex = 37;
            // 
            // paymentReferenceDataGrid
            // 
            this.paymentReferenceDataGrid.AllowUserToAddRows = false;
            this.paymentReferenceDataGrid.AllowUserToDeleteRows = false;
            this.paymentReferenceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentReferenceDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.paymentReferenceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentReferenceDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentReferenceDataGrid.Location = new System.Drawing.Point(453, 56);
            this.paymentReferenceDataGrid.MultiSelect = false;
            this.paymentReferenceDataGrid.Name = "paymentReferenceDataGrid";
            this.paymentReferenceDataGrid.ReadOnly = true;
            this.paymentReferenceDataGrid.RowHeadersWidth = 62;
            this.paymentReferenceDataGrid.RowTemplate.Height = 28;
            this.paymentReferenceDataGrid.Size = new System.Drawing.Size(697, 232);
            this.paymentReferenceDataGrid.TabIndex = 4;
            this.paymentReferenceDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentReferenceDataGrid_CellClick);
            // 
            // addPaymentReferenceButton
            // 
            this.addPaymentReferenceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPaymentReferenceButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPaymentReferenceButton.Location = new System.Drawing.Point(453, 311);
            this.addPaymentReferenceButton.Name = "addPaymentReferenceButton";
            this.addPaymentReferenceButton.Size = new System.Drawing.Size(361, 50);
            this.addPaymentReferenceButton.TabIndex = 2;
            this.addPaymentReferenceButton.Text = "Add File (Doc, PDF)";
            this.addPaymentReferenceButton.UseVisualStyleBackColor = true;
            this.addPaymentReferenceButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // referencePictureBox
            // 
            this.referencePictureBox.BackgroundImage = global::Stall_Rental_Management_System.Properties.Resources.image_placeholder;
            this.referencePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.referencePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.referencePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.referencePictureBox.Location = new System.Drawing.Point(19, 56);
            this.referencePictureBox.Name = "referencePictureBox";
            this.referencePictureBox.Size = new System.Drawing.Size(410, 305);
            this.referencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.referencePictureBox.TabIndex = 1;
            this.referencePictureBox.TabStop = false;
            this.referencePictureBox.Click += new System.EventHandler(this.referencePictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Reference Image";
            // 
            // paymentDateTime
            // 
            this.paymentDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.paymentDateTime.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDateTime.Location = new System.Drawing.Point(230, 207);
            this.paymentDateTime.Name = "paymentDateTime";
            this.paymentDateTime.Size = new System.Drawing.Size(352, 43);
            this.paymentDateTime.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 42);
            this.label6.TabIndex = 38;
            this.label6.Text = "Payment Date:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(230, 291);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(352, 50);
            this.amountTextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 42);
            this.label7.TabIndex = 40;
            this.label7.Text = "Amount:";
            // 
            // searchPaymentTextBox
            // 
            this.searchPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPaymentTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPaymentTextBox.Location = new System.Drawing.Point(197, 801);
            this.searchPaymentTextBox.Multiline = true;
            this.searchPaymentTextBox.Name = "searchPaymentTextBox";
            this.searchPaymentTextBox.Size = new System.Drawing.Size(261, 50);
            this.searchPaymentTextBox.TabIndex = 41;
            // 
            // SeachButton
            // 
            this.SeachButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeachButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachButton.Location = new System.Drawing.Point(28, 799);
            this.SeachButton.Name = "SeachButton";
            this.SeachButton.Size = new System.Drawing.Size(144, 50);
            this.SeachButton.TabIndex = 4;
            this.SeachButton.Text = "Search";
            this.SeachButton.UseVisualStyleBackColor = true;
            this.SeachButton.Click += new System.EventHandler(this.SeachButton_Click);
            // 
            // newButton
            // 
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(546, 799);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(144, 50);
            this.newButton.TabIndex = 42;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(718, 799);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 50);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(889, 799);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(144, 50);
            this.updateButton.TabIndex = 44;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePaymentButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePaymentButton.ForeColor = System.Drawing.Color.Red;
            this.deletePaymentButton.Location = new System.Drawing.Point(1057, 801);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(144, 50);
            this.deletePaymentButton.TabIndex = 4;
            this.deletePaymentButton.Text = "Delete";
            this.deletePaymentButton.UseVisualStyleBackColor = true;
            this.deletePaymentButton.Click += new System.EventHandler(this.deletePaymentButton_Click);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentDataGridView.Location = new System.Drawing.Point(28, 876);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.RowHeadersWidth = 62;
            this.paymentDataGridView.RowTemplate.Height = 28;
            this.paymentDataGridView.Size = new System.Drawing.Size(1175, 306);
            this.paymentDataGridView.TabIndex = 45;
            this.paymentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentDataGridView_CellClick);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.previousButton.Image = global::Stall_Rental_Management_System.Properties.Resources.arrow_left;
            this.previousButton.Location = new System.Drawing.Point(28, 31);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(40, 47);
            this.previousButton.TabIndex = 26;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(926, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 42);
            this.label9.TabIndex = 5;
            this.label9.Text = "@Copyright 2024";
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 1204);
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(this.deletePaymentButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.SeachButton);
            this.Controls.Add(this.searchPaymentTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paymentDateTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoiceNoComboBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Name = "FrmPayment";
            this.Text = "FrmPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentReferenceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.ComboBox invoiceNoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker paymentDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox referencePictureBox;
        private System.Windows.Forms.Button addPaymentReferenceButton;
        private System.Windows.Forms.TextBox searchPaymentTextBox;
        private System.Windows.Forms.Button SeachButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deletePaymentButton;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DataGridView paymentReferenceDataGrid;
        private System.Windows.Forms.Label label9;
    }
}