namespace Stall_Rental_Management_System.Views.Supermarket_Staff_Forms
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlStaff = new System.Windows.Forms.TabControl();
            this.tabPageStaffList = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageStaffDetail = new System.Windows.Forms.TabPage();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFirstNameEn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLastNameEn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFirstNameKh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastNameKh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUploadProfile = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.dataSet11 = new Stall_Rental_Management_System.DataSet1();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControlStaff.SuspendLayout();
            this.tabPageStaffList.SuspendLayout();
            this.tabPageStaffDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 89);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::Stall_Rental_Management_System.Properties.Resources.arrow_left;
            this.buttonBack.Location = new System.Drawing.Point(20, 20);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 44);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(1052, 24);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(148, 45);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // tabControlStaff
            // 
            this.tabControlStaff.Controls.Add(this.tabPageStaffList);
            this.tabControlStaff.Controls.Add(this.tabPageStaffDetail);
            this.tabControlStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStaff.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStaff.Location = new System.Drawing.Point(0, 89);
            this.tabControlStaff.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlStaff.Name = "tabControlStaff";
            this.tabControlStaff.Padding = new System.Drawing.Point(21, 3);
            this.tabControlStaff.SelectedIndex = 0;
            this.tabControlStaff.Size = new System.Drawing.Size(1226, 1097);
            this.tabControlStaff.TabIndex = 2;
            // 
            // tabPageStaffList
            // 
            this.tabPageStaffList.Controls.Add(this.dataGridViewStaff);
            this.tabPageStaffList.Controls.Add(this.buttonDelete);
            this.tabPageStaffList.Controls.Add(this.buttonEdit);
            this.tabPageStaffList.Controls.Add(this.buttonSearch);
            this.tabPageStaffList.Controls.Add(this.buttonAddNew);
            this.tabPageStaffList.Controls.Add(this.textBoxSearch);
            this.tabPageStaffList.Controls.Add(this.label2);
            this.tabPageStaffList.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStaffList.Location = new System.Drawing.Point(4, 50);
            this.tabPageStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStaffList.Name = "tabPageStaffList";
            this.tabPageStaffList.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStaffList.Size = new System.Drawing.Size(1218, 1043);
            this.tabPageStaffList.TabIndex = 0;
            this.tabPageStaffList.Text = "Staff List";
            this.tabPageStaffList.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1049, 220);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 44);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(1049, 157);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 44);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(603, 28);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(57, 45);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.Location = new System.Drawing.Point(1049, 92);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(148, 44);
            this.buttonAddNew.TabIndex = 3;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(185, 28);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(400, 42);
            this.textBoxSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Staff";
            // 
            // tabPageStaffDetail
            // 
            this.tabPageStaffDetail.Controls.Add(this.comboBoxPosition);
            this.tabPageStaffDetail.Controls.Add(this.dateTimeBirthDate);
            this.tabPageStaffDetail.Controls.Add(this.label14);
            this.tabPageStaffDetail.Controls.Add(this.textBoxFirstNameEn);
            this.tabPageStaffDetail.Controls.Add(this.label12);
            this.tabPageStaffDetail.Controls.Add(this.textBoxLastNameEn);
            this.tabPageStaffDetail.Controls.Add(this.label13);
            this.tabPageStaffDetail.Controls.Add(this.buttonCancel);
            this.tabPageStaffDetail.Controls.Add(this.buttonSave);
            this.tabPageStaffDetail.Controls.Add(this.richTextBoxAddress);
            this.tabPageStaffDetail.Controls.Add(this.label11);
            this.tabPageStaffDetail.Controls.Add(this.textBoxPassword);
            this.tabPageStaffDetail.Controls.Add(this.label10);
            this.tabPageStaffDetail.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageStaffDetail.Controls.Add(this.label9);
            this.tabPageStaffDetail.Controls.Add(this.label8);
            this.tabPageStaffDetail.Controls.Add(this.textBoxEmail);
            this.tabPageStaffDetail.Controls.Add(this.label7);
            this.tabPageStaffDetail.Controls.Add(this.comboBoxGender);
            this.tabPageStaffDetail.Controls.Add(this.label6);
            this.tabPageStaffDetail.Controls.Add(this.textBoxFirstNameKh);
            this.tabPageStaffDetail.Controls.Add(this.label5);
            this.tabPageStaffDetail.Controls.Add(this.textBoxLastNameKh);
            this.tabPageStaffDetail.Controls.Add(this.label4);
            this.tabPageStaffDetail.Controls.Add(this.buttonUploadProfile);
            this.tabPageStaffDetail.Controls.Add(this.pictureBoxProfile);
            this.tabPageStaffDetail.Controls.Add(this.textBoxStaffId);
            this.tabPageStaffDetail.Controls.Add(this.label3);
            this.tabPageStaffDetail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStaffDetail.Location = new System.Drawing.Point(4, 50);
            this.tabPageStaffDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStaffDetail.Name = "tabPageStaffDetail";
            this.tabPageStaffDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStaffDetail.Size = new System.Drawing.Size(1218, 1043);
            this.tabPageStaffDetail.TabIndex = 1;
            this.tabPageStaffDetail.Text = "Staff Detail";
            this.tabPageStaffDetail.UseVisualStyleBackColor = true;
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthDate.Location = new System.Drawing.Point(253, 398);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(613, 42);
            this.dateTimeBirthDate.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 399);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 42);
            this.label14.TabIndex = 30;
            this.label14.Text = "Birth Date";
            // 
            // textBoxFirstNameEn
            // 
            this.textBoxFirstNameEn.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstNameEn.Location = new System.Drawing.Point(254, 315);
            this.textBoxFirstNameEn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstNameEn.Name = "textBoxFirstNameEn";
            this.textBoxFirstNameEn.Size = new System.Drawing.Size(612, 42);
            this.textBoxFirstNameEn.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 317);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 42);
            this.label12.TabIndex = 28;
            this.label12.Text = "First Name EN";
            // 
            // textBoxLastNameEn
            // 
            this.textBoxLastNameEn.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastNameEn.Location = new System.Drawing.Point(254, 241);
            this.textBoxLastNameEn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastNameEn.Name = "textBoxLastNameEn";
            this.textBoxLastNameEn.Size = new System.Drawing.Size(612, 42);
            this.textBoxLastNameEn.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 42);
            this.label13.TabIndex = 26;
            this.label13.Text = "Last Name EN";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(970, 969);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(226, 45);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(970, 900);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(226, 45);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(253, 832);
            this.richTextBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(612, 187);
            this.richTextBoxAddress.TabIndex = 24;
            this.richTextBoxAddress.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 832);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 42);
            this.label11.TabIndex = 22;
            this.label11.Text = "Address";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(253, 761);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(612, 42);
            this.textBoxPassword.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 763);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 42);
            this.label10.TabIndex = 20;
            this.label10.Text = "Password";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(253, 691);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(612, 42);
            this.textBoxPhoneNumber.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 693);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 42);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 42);
            this.label8.TabIndex = 16;
            this.label8.Text = "Position";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(253, 553);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(612, 42);
            this.textBoxEmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 42);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(253, 475);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(612, 49);
            this.comboBoxGender.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // textBoxFirstNameKh
            // 
            this.textBoxFirstNameKh.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstNameKh.Location = new System.Drawing.Point(253, 164);
            this.textBoxFirstNameKh.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstNameKh.Name = "textBoxFirstNameKh";
            this.textBoxFirstNameKh.Size = new System.Drawing.Size(612, 42);
            this.textBoxFirstNameKh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name KH";
            // 
            // textBoxLastNameKh
            // 
            this.textBoxLastNameKh.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastNameKh.Location = new System.Drawing.Point(253, 90);
            this.textBoxLastNameKh.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastNameKh.Name = "textBoxLastNameKh";
            this.textBoxLastNameKh.Size = new System.Drawing.Size(612, 42);
            this.textBoxLastNameKh.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name KH";
            // 
            // buttonUploadProfile
            // 
            this.buttonUploadProfile.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadProfile.Image = global::Stall_Rental_Management_System.Properties.Resources.document_upload;
            this.buttonUploadProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUploadProfile.Location = new System.Drawing.Point(970, 341);
            this.buttonUploadProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUploadProfile.Name = "buttonUploadProfile";
            this.buttonUploadProfile.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.buttonUploadProfile.Size = new System.Drawing.Size(226, 45);
            this.buttonUploadProfile.TabIndex = 3;
            this.buttonUploadProfile.Text = "Upload Profile";
            this.buttonUploadProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUploadProfile.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(970, 22);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(226, 299);
            this.pictureBoxProfile.TabIndex = 7;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffId.Location = new System.Drawing.Point(253, 22);
            this.textBoxStaffId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(612, 42);
            this.textBoxStaffId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff ID";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(253, 620);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(612, 49);
            this.comboBoxPosition.TabIndex = 33;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(23, 92);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 72;
            this.dataGridViewStaff.RowTemplate.Height = 31;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1000, 928);
            this.dataGridViewStaff.TabIndex = 8;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1226, 1186);
            this.Controls.Add(this.tabControlStaff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlStaff.ResumeLayout(false);
            this.tabPageStaffList.ResumeLayout(false);
            this.tabPageStaffList.PerformLayout();
            this.tabPageStaffDetail.ResumeLayout(false);
            this.tabPageStaffDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlStaff;
        private System.Windows.Forms.TabPage tabPageStaffList;
        private System.Windows.Forms.TabPage tabPageStaffDetail;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxStaffId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUploadProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxLastNameKh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFirstNameKh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFirstNameEn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLastNameEn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private DataSet1 dataSet11;
    }
}