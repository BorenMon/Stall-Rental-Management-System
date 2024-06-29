namespace Stall_Rental_Management_System.Views
{
    partial class FrmVendor
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
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.uploadProfileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxFirstNameKh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLastNameKh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(935, 23);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 40);
            this.logoutButton.TabIndex = 25;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vendor Management";
            // 
            // profileBox
            // 
            this.profileBox.BackgroundImage = global::Stall_Rental_Management_System.Properties.Resources.user;
            this.profileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileBox.Location = new System.Drawing.Point(24, 89);
            this.profileBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(186, 208);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileBox.TabIndex = 26;
            this.profileBox.TabStop = false;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.previousButton.Image = global::Stall_Rental_Management_System.Properties.Resources.arrow_left;
            this.previousButton.Location = new System.Drawing.Point(24, 26);
            this.previousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(36, 38);
            this.previousButton.TabIndex = 23;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // uploadProfileButton
            // 
            this.uploadProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadProfileButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadProfileButton.Location = new System.Drawing.Point(24, 314);
            this.uploadProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadProfileButton.Name = "uploadProfileButton";
            this.uploadProfileButton.Size = new System.Drawing.Size(186, 40);
            this.uploadProfileButton.TabIndex = 27;
            this.uploadProfileButton.Text = "Upload Profile";
            this.uploadProfileButton.UseVisualStyleBackColor = true;
            this.uploadProfileButton.Click += new System.EventHandler(this.uploadProfileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name EN:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.lastNameTextBox.Location = new System.Drawing.Point(388, 89);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(246, 40);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "First Name EN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 35);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(387, 300);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(247, 43);
            this.genderComboBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 35);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 35);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(230, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 35);
            this.label8.TabIndex = 40;
            this.label8.Text = "Address:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.searchTextBox.Location = new System.Drawing.Point(23, 526);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(225, 41);
            this.searchTextBox.TabIndex = 43;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(267, 526);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 40);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.firstNameTextBox.Location = new System.Drawing.Point(822, 89);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(246, 40);
            this.firstNameTextBox.TabIndex = 45;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(821, 298);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(246, 40);
            this.emailTextBox.TabIndex = 46;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(387, 365);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(246, 40);
            this.phoneTextBox.TabIndex = 47;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(821, 365);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(246, 40);
            this.passwordTextBox.TabIndex = 48;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.addressTextBox.Location = new System.Drawing.Point(387, 436);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(680, 60);
            this.addressTextBox.TabIndex = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(947, 526);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 40);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(806, 526);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 40);
            this.updateButton.TabIndex = 51;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(666, 526);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(524, 526);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(120, 40);
            this.newButton.TabIndex = 53;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendorDataGridView.Location = new System.Drawing.Point(23, 591);
            this.vendorDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.RowHeadersWidth = 62;
            this.vendorDataGridView.RowTemplate.Height = 28;
            this.vendorDataGridView.Size = new System.Drawing.Size(1044, 226);
            this.vendorDataGridView.TabIndex = 54;
            this.vendorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDataGridView_CellClick);
            // 
            // textBoxFirstNameKh
            // 
            this.textBoxFirstNameKh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstNameKh.Font = new System.Drawing.Font("Poppins", 12F);
            this.textBoxFirstNameKh.Location = new System.Drawing.Point(821, 152);
            this.textBoxFirstNameKh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstNameKh.Multiline = true;
            this.textBoxFirstNameKh.Name = "textBoxFirstNameKh";
            this.textBoxFirstNameKh.Size = new System.Drawing.Size(246, 40);
            this.textBoxFirstNameKh.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 35);
            this.label9.TabIndex = 57;
            this.label9.Text = "First Name KH:";
            // 
            // textBoxLastNameKh
            // 
            this.textBoxLastNameKh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastNameKh.Font = new System.Drawing.Font("Poppins", 12F);
            this.textBoxLastNameKh.Location = new System.Drawing.Point(387, 152);
            this.textBoxLastNameKh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastNameKh.Multiline = true;
            this.textBoxLastNameKh.Name = "textBoxLastNameKh";
            this.textBoxLastNameKh.Size = new System.Drawing.Size(246, 40);
            this.textBoxLastNameKh.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 35);
            this.label10.TabIndex = 55;
            this.label10.Text = "Last Name KH:";
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthDate.Location = new System.Drawing.Point(387, 225);
            this.dateTimeBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(247, 37);
            this.dateTimeBirthDate.TabIndex = 128;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(231, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 35);
            this.label14.TabIndex = 127;
            this.label14.Text = "Birth Date";
            // 
            // FrmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 832);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxFirstNameKh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLastNameKh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadProfileButton);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVendor";
            this.ShowIcon = false;
            this.Text = "FrmVendor";
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.TextBox textBoxFirstNameKh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLastNameKh;
        private System.Windows.Forms.Label label10;

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.Button uploadProfileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView vendorDataGridView;
    }
}