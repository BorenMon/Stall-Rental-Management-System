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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMonthlyFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonUpdateOrSave = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStall)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 96);
            this.panel1.TabIndex = 100;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::Stall_Rental_Management_System.Properties.Resources.arrow_left;
            this.buttonBack.Location = new System.Drawing.Point(19, 21);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 48);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(1221, 26);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(147, 48);
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
            this.panel2.Location = new System.Drawing.Point(0, 978);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 460);
            this.panel2.TabIndex = 101;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(177, 18);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(393, 42);
            this.textBoxSearch.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 63;
            this.label2.Text = "Search Stall";
            // 
            // buttonAddNewStall
            // 
            this.buttonAddNewStall.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewStall.Location = new System.Drawing.Point(1050, 21);
            this.buttonAddNewStall.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNewStall.Name = "buttonAddNewStall";
            this.buttonAddNewStall.Size = new System.Drawing.Size(147, 46);
            this.buttonAddNewStall.TabIndex = 64;
            this.buttonAddNewStall.Text = "Add New";
            this.buttonAddNewStall.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Poppins", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::Stall_Rental_Management_System.Properties.Resources.search_normal;
            this.buttonSearch.Location = new System.Drawing.Point(588, 15);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(56, 48);
            this.buttonSearch.TabIndex = 65;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteStall
            // 
            this.buttonDeleteStall.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStall.Location = new System.Drawing.Point(1221, 21);
            this.buttonDeleteStall.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteStall.Name = "buttonDeleteStall";
            this.buttonDeleteStall.Size = new System.Drawing.Size(147, 46);
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
            this.dataGridViewStall.Location = new System.Drawing.Point(19, 92);
            this.dataGridViewStall.MultiSelect = false;
            this.dataGridViewStall.Name = "dataGridViewStall";
            this.dataGridViewStall.ReadOnly = true;
            this.dataGridViewStall.RowHeadersWidth = 72;
            this.dataGridViewStall.RowTemplate.Height = 31;
            this.dataGridViewStall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStall.Size = new System.Drawing.Size(1349, 339);
            this.dataGridViewStall.TabIndex = 69;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.label14);
            this.panelDetail.Controls.Add(this.textBoxMonthlyFee);
            this.panelDetail.Controls.Add(this.label12);
            this.panelDetail.Controls.Add(this.textBoxSize);
            this.panelDetail.Controls.Add(this.label13);
            this.panelDetail.Controls.Add(this.buttonUpdateOrSave);
            this.panelDetail.Controls.Add(this.comboBoxType);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.textBoxStatus);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.textBoxCode);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 96);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1390, 882);
            this.panelDetail.TabIndex = 102;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 264);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 42);
            this.label14.TabIndex = 136;
            this.label14.Text = "Location";
            // 
            // textBoxMonthlyFee
            // 
            this.textBoxMonthlyFee.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonthlyFee.Location = new System.Drawing.Point(887, 180);
            this.textBoxMonthlyFee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonthlyFee.Name = "textBoxMonthlyFee";
            this.textBoxMonthlyFee.Size = new System.Drawing.Size(480, 42);
            this.textBoxMonthlyFee.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(667, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 42);
            this.label12.TabIndex = 134;
            this.label12.Text = "Monthly Fee ($)";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(168, 182);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(480, 42);
            this.textBoxSize.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 183);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 42);
            this.label13.TabIndex = 132;
            this.label13.Text = "Size (m2)";
            // 
            // buttonUpdateOrSave
            // 
            this.buttonUpdateOrSave.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrSave.Location = new System.Drawing.Point(1221, 20);
            this.buttonUpdateOrSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateOrSave.Name = "buttonUpdateOrSave";
            this.buttonUpdateOrSave.Size = new System.Drawing.Size(147, 48);
            this.buttonUpdateOrSave.TabIndex = 124;
            this.buttonUpdateOrSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(887, 99);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(480, 48);
            this.comboBoxType.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 42);
            this.label5.TabIndex = 129;
            this.label5.Text = "Type";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(168, 99);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(480, 42);
            this.textBoxStatus.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 42);
            this.label4.TabIndex = 127;
            this.label4.Text = "Status";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(168, 22);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(480, 42);
            this.textBoxCode.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 42);
            this.label3.TabIndex = 125;
            this.label3.Text = "Code";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1390, 1438);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInvoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System / Staff Panel / Invoice Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStall)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMonthlyFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUpdateOrSave;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label3;
    }
}