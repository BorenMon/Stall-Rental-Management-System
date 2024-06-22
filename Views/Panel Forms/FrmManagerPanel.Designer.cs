namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    partial class FrmManagerPanel
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonStaffs = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonStalls = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonLogout.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Image = global::Stall_Rental_Management_System.Properties.Resources.logout;
            this.buttonLogout.Location = new System.Drawing.Point(1033, 30);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(160, 50);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonProfile.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.Transparent;
            this.buttonProfile.Image = global::Stall_Rental_Management_System.Properties.Resources.profile;
            this.buttonProfile.Location = new System.Drawing.Point(844, 30);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(160, 50);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(26, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(239, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Manager Panel";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::Stall_Rental_Management_System.Properties.Resources.graph;
            this.buttonReport.Location = new System.Drawing.Point(35, 342);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(350, 150);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = false;
            // 
            // buttonStaffs
            // 
            this.buttonStaffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffs.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaffs.ForeColor = System.Drawing.Color.White;
            this.buttonStaffs.Image = global::Stall_Rental_Management_System.Properties.Resources.people;
            this.buttonStaffs.Location = new System.Drawing.Point(843, 143);
            this.buttonStaffs.Name = "buttonStaffs";
            this.buttonStaffs.Size = new System.Drawing.Size(350, 150);
            this.buttonStaffs.TabIndex = 3;
            this.buttonStaffs.Text = "Staffs";
            this.buttonStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStaffs.UseVisualStyleBackColor = false;
            this.buttonStaffs.Click += new System.EventHandler(this.buttonStaffs_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContracts.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContracts.ForeColor = System.Drawing.Color.White;
            this.buttonContracts.Image = global::Stall_Rental_Management_System.Properties.Resources.note;
            this.buttonContracts.Location = new System.Drawing.Point(440, 143);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(350, 150);
            this.buttonContracts.TabIndex = 2;
            this.buttonContracts.Text = "Contracts";
            this.buttonContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonContracts.UseVisualStyleBackColor = false;
            // 
            // buttonStalls
            // 
            this.buttonStalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(172)))));
            this.buttonStalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStalls.Font = new System.Drawing.Font("Poppins Medium", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStalls.ForeColor = System.Drawing.Color.White;
            this.buttonStalls.Image = global::Stall_Rental_Management_System.Properties.Resources.building;
            this.buttonStalls.Location = new System.Drawing.Point(35, 143);
            this.buttonStalls.Name = "buttonStalls";
            this.buttonStalls.Size = new System.Drawing.Size(350, 150);
            this.buttonStalls.TabIndex = 1;
            this.buttonStalls.Text = "Stalls";
            this.buttonStalls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStalls.UseVisualStyleBackColor = false;
            this.buttonStalls.Click += new System.EventHandler(this.buttonStalls_Click);
            // 
            // FrmManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 763);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonStaffs);
            this.Controls.Add(this.buttonContracts);
            this.Controls.Add(this.buttonStalls);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManagerPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Rental Management System / Manager Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStalls;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonStaffs;
        private System.Windows.Forms.Button buttonReport;
    }
}