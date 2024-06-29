using System.ComponentModel;

namespace Stall_Rental_Management_System.Views
{
    partial class FrmStallForManager
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
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panelImages = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMonthlyFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonUpdateOrSave = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddNewStall = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDeleteStall = new System.Windows.Forms.Button();
            this.dataGridViewStall = new System.Windows.Forms.DataGridView();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxImagesFileName = new System.Windows.Forms.ListBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelDetail.SuspendLayout();
            this.panelImages.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.panelImages);
            this.panelDetail.Controls.Add(this.panel3);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 64);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1011, 588);
            this.panelDetail.TabIndex = 102;
            // 
            // panelImages
            // 
            this.panelImages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Controls.Add(this.buttonAddImage);
            this.panelImages.Controls.Add(this.buttonRemoveImage);
            this.panelImages.Controls.Add(this.listBoxImagesFileName);
            this.panelImages.Controls.Add(this.label6);
            this.panelImages.Controls.Add(this.pictureBoxImage);
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(0, 227);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1011, 361);
            this.panelImages.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBoxMonthlyFee);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBoxSize);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.buttonUpdateOrSave);
            this.panel3.Controls.Add(this.comboBoxType);
            this.panel3.Controls.Add(this.textBoxLocation);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxStatus);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxCode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 227);
            this.panel3.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 30);
            this.label14.TabIndex = 136;
            this.label14.Text = "Location";
            // 
            // textBoxMonthlyFee
            // 
            this.textBoxMonthlyFee.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyFee.Location = new System.Drawing.Point(645, 120);
            this.textBoxMonthlyFee.Name = "textBoxMonthlyFee";
            this.textBoxMonthlyFee.Size = new System.Drawing.Size(350, 32);
            this.textBoxMonthlyFee.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 30);
            this.label12.TabIndex = 134;
            this.label12.Text = "Monthly Fee ($)";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(122, 121);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(350, 32);
            this.textBoxSize.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 30);
            this.label13.TabIndex = 132;
            this.label13.Text = "Size (m2)";
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
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(645, 66);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(350, 36);
            this.comboBoxType.TabIndex = 131;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(122, 175);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(873, 32);
            this.textBoxLocation.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.TabIndex = 129;
            this.label5.Text = "Type";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(122, 66);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(350, 32);
            this.textBoxStatus.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 127;
            this.label4.Text = "Status";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(122, 15);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(350, 32);
            this.textBoxCode.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 30);
            this.label3.TabIndex = 125;
            this.label3.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stall Management";
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
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonAddNewStall);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.buttonDeleteStall);
            this.panel2.Controls.Add(this.dataGridViewStall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 307);
            this.panel2.TabIndex = 101;
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
            this.buttonAddNewStall.Location = new System.Drawing.Point(764, 14);
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
            // buttonDeleteStall
            // 
            this.buttonDeleteStall.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStall.Location = new System.Drawing.Point(888, 14);
            this.buttonDeleteStall.Name = "buttonDeleteStall";
            this.buttonDeleteStall.Size = new System.Drawing.Size(107, 31);
            this.buttonDeleteStall.TabIndex = 68;
            this.buttonDeleteStall.Text = "Delete";
            this.buttonDeleteStall.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStall
            // 
            this.dataGridViewStall.AllowUserToAddRows = false;
            this.dataGridViewStall.AllowUserToDeleteRows = false;
            this.dataGridViewStall.AllowUserToResizeColumns = false;
            this.dataGridViewStall.AllowUserToResizeRows = false;
            this.dataGridViewStall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStall.Location = new System.Drawing.Point(14, 61);
            this.dataGridViewStall.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStall.MultiSelect = false;
            this.dataGridViewStall.Name = "dataGridViewStall";
            this.dataGridViewStall.ReadOnly = true;
            this.dataGridViewStall.RowHeadersWidth = 72;
            this.dataGridViewStall.RowTemplate.Height = 31;
            this.dataGridViewStall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStall.Size = new System.Drawing.Size(981, 226);
            this.dataGridViewStall.TabIndex = 69;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(17, 64);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(277, 277);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1009, 47);
            this.label6.TabIndex = 1;
            this.label6.Text = "Images";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxImagesFileName
            // 
            this.listBoxImagesFileName.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxImagesFileName.FormattingEnabled = true;
            this.listBoxImagesFileName.ItemHeight = 30;
            this.listBoxImagesFileName.Location = new System.Drawing.Point(314, 127);
            this.listBoxImagesFileName.Name = "listBoxImagesFileName";
            this.listBoxImagesFileName.Size = new System.Drawing.Size(680, 214);
            this.listBoxImagesFileName.TabIndex = 2;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddImage.Location = new System.Drawing.Point(314, 64);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(107, 31);
            this.buttonAddImage.TabIndex = 69;
            this.buttonAddImage.Text = "Add";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(438, 64);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(107, 31);
            this.buttonRemoveImage.TabIndex = 70;
            this.buttonRemoveImage.Text = "Remove";
            this.buttonRemoveImage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FrmStall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 959);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FrmStallForManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System / Manager Panel / Stall Management";
            this.panelDetail.ResumeLayout(false);
            this.panelImages.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewStall;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDeleteStall;
        private System.Windows.Forms.DataGridView dataGridViewStall;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMonthlyFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUpdateOrSave;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.ListBox listBoxImagesFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}