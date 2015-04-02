namespace AdmissionTrackingApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoginStatus_Login = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.txtAccount_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLoginStatus_Login);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPassword_Login);
            this.panel1.Controls.Add(this.txtAccount_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 210);
            this.panel1.TabIndex = 0;
            // 
            // lbLoginStatus_Login
            // 
            this.lbLoginStatus_Login.AutoSize = true;
            this.lbLoginStatus_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoginStatus_Login.ForeColor = System.Drawing.Color.Red;
            this.lbLoginStatus_Login.Location = new System.Drawing.Point(120, 106);
            this.lbLoginStatus_Login.Name = "lbLoginStatus_Login";
            this.lbLoginStatus_Login.Size = new System.Drawing.Size(110, 13);
            this.lbLoginStatus_Login.TabIndex = 5;
            this.lbLoginStatus_Login.Text = "inform login status";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(155, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Location = new System.Drawing.Point(102, 73);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.Size = new System.Drawing.Size(223, 20);
            this.txtPassword_Login.TabIndex = 3;
            this.txtPassword_Login.UseSystemPasswordChar = true;
            // 
            // txtAccount_Login
            // 
            this.txtAccount_Login.Location = new System.Drawing.Point(102, 38);
            this.txtAccount_Login.Name = "txtAccount_Login";
            this.txtAccount_Login.Size = new System.Drawing.Size(223, 20);
            this.txtAccount_Login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(416, 257);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.TextBox txtAccount_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLoginStatus_Login;

    }
}

