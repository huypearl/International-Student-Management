namespace AdmissionTrackingApp
{
    partial class frmChangePass
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
            this.txtOldPass_ChangePass = new System.Windows.Forms.TextBox();
            this.txtNewPass_ChangePass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAccount_ChangePass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirm_ChangePass = new System.Windows.Forms.TextBox();
            this.btnSave_ChangePass = new System.Windows.Forms.Button();
            this.btnCancel_ChangePass = new System.Windows.Forms.Button();
            this.lbNotify_ChangePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldPass_ChangePass
            // 
            this.txtOldPass_ChangePass.Location = new System.Drawing.Point(138, 96);
            this.txtOldPass_ChangePass.Name = "txtOldPass_ChangePass";
            this.txtOldPass_ChangePass.Size = new System.Drawing.Size(223, 20);
            this.txtOldPass_ChangePass.TabIndex = 7;
            // 
            // txtNewPass_ChangePass
            // 
            this.txtNewPass_ChangePass.Location = new System.Drawing.Point(138, 135);
            this.txtNewPass_ChangePass.Name = "txtNewPass_ChangePass";
            this.txtNewPass_ChangePass.Size = new System.Drawing.Size(223, 20);
            this.txtNewPass_ChangePass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Old Password";
            // 
            // lbAccount_ChangePass
            // 
            this.lbAccount_ChangePass.AutoSize = true;
            this.lbAccount_ChangePass.Location = new System.Drawing.Point(198, 45);
            this.lbAccount_ChangePass.Name = "lbAccount_ChangePass";
            this.lbAccount_ChangePass.Size = new System.Drawing.Size(47, 13);
            this.lbAccount_ChangePass.TabIndex = 4;
            this.lbAccount_ChangePass.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm";
            // 
            // txtConfirm_ChangePass
            // 
            this.txtConfirm_ChangePass.Location = new System.Drawing.Point(138, 172);
            this.txtConfirm_ChangePass.Name = "txtConfirm_ChangePass";
            this.txtConfirm_ChangePass.Size = new System.Drawing.Size(223, 20);
            this.txtConfirm_ChangePass.TabIndex = 10;
            // 
            // btnSave_ChangePass
            // 
            this.btnSave_ChangePass.Location = new System.Drawing.Point(100, 240);
            this.btnSave_ChangePass.Name = "btnSave_ChangePass";
            this.btnSave_ChangePass.Size = new System.Drawing.Size(75, 23);
            this.btnSave_ChangePass.TabIndex = 11;
            this.btnSave_ChangePass.Text = "Save";
            this.btnSave_ChangePass.UseVisualStyleBackColor = true;
            this.btnSave_ChangePass.Click += new System.EventHandler(this.btnSave_ChangePass_Click);
            // 
            // btnCancel_ChangePass
            // 
            this.btnCancel_ChangePass.Location = new System.Drawing.Point(225, 240);
            this.btnCancel_ChangePass.Name = "btnCancel_ChangePass";
            this.btnCancel_ChangePass.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_ChangePass.TabIndex = 12;
            this.btnCancel_ChangePass.Text = "Cancel";
            this.btnCancel_ChangePass.UseVisualStyleBackColor = true;
            // 
            // lbNotify_ChangePass
            // 
            this.lbNotify_ChangePass.AutoSize = true;
            this.lbNotify_ChangePass.ForeColor = System.Drawing.Color.Crimson;
            this.lbNotify_ChangePass.Location = new System.Drawing.Point(115, 208);
            this.lbNotify_ChangePass.Name = "lbNotify_ChangePass";
            this.lbNotify_ChangePass.Size = new System.Drawing.Size(0, 13);
            this.lbNotify_ChangePass.TabIndex = 13;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 316);
            this.Controls.Add(this.lbNotify_ChangePass);
            this.Controls.Add(this.btnCancel_ChangePass);
            this.Controls.Add(this.btnSave_ChangePass);
            this.Controls.Add(this.txtConfirm_ChangePass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPass_ChangePass);
            this.Controls.Add(this.txtNewPass_ChangePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAccount_ChangePass);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass_ChangePass;
        private System.Windows.Forms.TextBox txtNewPass_ChangePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAccount_ChangePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirm_ChangePass;
        private System.Windows.Forms.Button btnSave_ChangePass;
        private System.Windows.Forms.Button btnCancel_ChangePass;
        private System.Windows.Forms.Label lbNotify_ChangePass;
    }
}