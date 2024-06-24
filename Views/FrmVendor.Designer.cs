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
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Red;
            this.logoutButton.Location = new System.Drawing.Point(1052, 29);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 50);
            this.logoutButton.TabIndex = 25;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 56);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vendor Management";
            // 
            // profileBox
            // 
            this.profileBox.BackgroundImage = global::Stall_Rental_Management_System.Properties.Resources.user;
            this.profileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileBox.Location = new System.Drawing.Point(27, 111);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(209, 259);
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
            this.previousButton.Location = new System.Drawing.Point(27, 32);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(40, 47);
            this.previousButton.TabIndex = 23;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // uploadProfileButton
            // 
            this.uploadProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadProfileButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadProfileButton.Location = new System.Drawing.Point(27, 392);
            this.uploadProfileButton.Name = "uploadProfileButton";
            this.uploadProfileButton.Size = new System.Drawing.Size(209, 50);
            this.uploadProfileButton.TabIndex = 27;
            this.uploadProfileButton.Text = "Upload Profile";
            this.uploadProfileButton.UseVisualStyleBackColor = true;
            this.uploadProfileButton.Click += new System.EventHandler(this.uploadProfileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.lastNameTextBox.Location = new System.Drawing.Point(437, 111);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(277, 50);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 42);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(437, 197);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(277, 50);
            this.genderComboBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(748, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 42);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 42);
            this.label6.TabIndex = 36;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 42);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 42);
            this.label8.TabIndex = 40;
            this.label8.Text = "Address:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.searchTextBox.Location = new System.Drawing.Point(27, 504);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(253, 50);
            this.searchTextBox.TabIndex = 43;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(302, 504);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 50);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.firstNameTextBox.Location = new System.Drawing.Point(925, 111);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(277, 50);
            this.firstNameTextBox.TabIndex = 45;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(925, 195);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(277, 50);
            this.emailTextBox.TabIndex = 46;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(437, 279);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(277, 50);
            this.phoneTextBox.TabIndex = 47;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(925, 279);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(277, 50);
            this.passwordTextBox.TabIndex = 48;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Poppins", 12F);
            this.addressTextBox.Location = new System.Drawing.Point(437, 367);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(765, 75);
            this.addressTextBox.TabIndex = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(1067, 504);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 50);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(908, 504);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(135, 50);
            this.updateButton.TabIndex = 51;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(750, 504);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 50);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(591, 504);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(135, 50);
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
            this.vendorDataGridView.Location = new System.Drawing.Point(27, 585);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.RowHeadersWidth = 62;
            this.vendorDataGridView.RowTemplate.Height = 28;
            this.vendorDataGridView.Size = new System.Drawing.Size(1175, 282);
            this.vendorDataGridView.TabIndex = 54;
            this.vendorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDataGridView_CellClick);
            // 
            // FrmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 890);
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
            this.Name = "FrmVendor";
            this.Text = "FrmVendor";
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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