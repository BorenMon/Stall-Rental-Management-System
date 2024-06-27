using System.ComponentModel;

namespace Stall_Rental_Management_System.Views
{
    partial class FrmChangePassword
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
            this.textBoxCurrentPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCurrentPwd
            // 
            this.textBoxCurrentPwd.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPwd.Location = new System.Drawing.Point(182, 22);
            this.textBoxCurrentPwd.Name = "textBoxCurrentPwd";
            this.textBoxCurrentPwd.PasswordChar = '*';
            this.textBoxCurrentPwd.Size = new System.Drawing.Size(388, 32);
            this.textBoxCurrentPwd.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 105;
            this.label4.Text = "Current Password";
            // 
            // textBoxNewPwd
            // 
            this.textBoxNewPwd.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPwd.Location = new System.Drawing.Point(182, 76);
            this.textBoxNewPwd.Name = "textBoxNewPwd";
            this.textBoxNewPwd.PasswordChar = '*';
            this.textBoxNewPwd.Size = new System.Drawing.Size(388, 32);
            this.textBoxNewPwd.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 107;
            this.label1.Text = "New Password";
            // 
            // textBoxConfirmPwd
            // 
            this.textBoxConfirmPwd.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPwd.Location = new System.Drawing.Point(182, 132);
            this.textBoxConfirmPwd.Name = "textBoxConfirmPwd";
            this.textBoxConfirmPwd.PasswordChar = '*';
            this.textBoxConfirmPwd.Size = new System.Drawing.Size(388, 32);
            this.textBoxConfirmPwd.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 109;
            this.label2.Text = "Confirm Password";
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChange.Location = new System.Drawing.Point(13, 193);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonChange.Size = new System.Drawing.Size(557, 32);
            this.buttonChange.TabIndex = 126;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 242);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxConfirmPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurrentPwd);
            this.Controls.Add(this.label4);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stall Rental Management System / Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonChange;

        private System.Windows.Forms.TextBox textBoxNewPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPwd;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxCurrentPwd;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}