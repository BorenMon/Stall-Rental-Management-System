namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    partial class FrmStaffPanel
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
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.buttonVendors = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonStalls = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.BackColor = System.Drawing.Color.White;
            this.buttonInvoices.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInvoices.Location = new System.Drawing.Point(19, 157);
            this.buttonInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(255, 100);
            this.buttonInvoices.TabIndex = 8;
            this.buttonInvoices.Text = "Invoices";
            this.buttonInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInvoices.UseVisualStyleBackColor = false;
            this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
            // 
            // buttonVendors
            // 
            this.buttonVendors.BackColor = System.Drawing.Color.White;
            this.buttonVendors.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVendors.Location = new System.Drawing.Point(607, 24);
            this.buttonVendors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVendors.Name = "buttonVendors";
            this.buttonVendors.Size = new System.Drawing.Size(255, 100);
            this.buttonVendors.TabIndex = 7;
            this.buttonVendors.Text = "Vendors";
            this.buttonVendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVendors.UseVisualStyleBackColor = false;
            this.buttonVendors.Click += new System.EventHandler(this.buttonVendors_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.BackColor = System.Drawing.Color.White;
            this.buttonContracts.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContracts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonContracts.Location = new System.Drawing.Point(314, 24);
            this.buttonContracts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(255, 100);
            this.buttonContracts.TabIndex = 6;
            this.buttonContracts.Text = "Contracts";
            this.buttonContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonContracts.UseVisualStyleBackColor = false;
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonStalls
            // 
            this.buttonStalls.BackColor = System.Drawing.Color.White;
            this.buttonStalls.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStalls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStalls.Location = new System.Drawing.Point(19, 24);
            this.buttonStalls.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStalls.Name = "buttonStalls";
            this.buttonStalls.Size = new System.Drawing.Size(255, 100);
            this.buttonStalls.TabIndex = 5;
            this.buttonStalls.Text = "Stalls";
            this.buttonStalls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStalls.UseVisualStyleBackColor = false;
            this.buttonStalls.Click += new System.EventHandler(this.buttonStalls_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPayments);
            this.panel2.Controls.Add(this.buttonInvoices);
            this.panel2.Controls.Add(this.buttonVendors);
            this.panel2.Controls.Add(this.buttonContracts);
            this.panel2.Controls.Add(this.buttonStalls);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 425);
            this.panel2.TabIndex = 7;
            // 
            // buttonPayments
            // 
            this.buttonPayments.BackColor = System.Drawing.Color.White;
            this.buttonPayments.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPayments.Location = new System.Drawing.Point(314, 157);
            this.buttonPayments.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(255, 100);
            this.buttonPayments.TabIndex = 9;
            this.buttonPayments.Text = "Payments";
            this.buttonPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPayments.UseVisualStyleBackColor = false;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 67);
            this.panel1.TabIndex = 8;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogout.Location = new System.Drawing.Point(751, 20);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(116, 33);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.White;
            this.buttonProfile.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProfile.Location = new System.Drawing.Point(614, 20);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(116, 33);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(19, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 35);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Staff Panel";
            // 
            // FrmStaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmStaffPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System / Staff Panel";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonPayments;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Button buttonVendors;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonStalls;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}