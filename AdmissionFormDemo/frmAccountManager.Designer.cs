namespace AdmissionTrackingApp
{
    partial class frmAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete_AccoutManager = new System.Windows.Forms.Button();
            this.btnEdit_AccoutManager = new System.Windows.Forms.Button();
            this.btnAdd_AccoutManager = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridList_AccountManager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername_AccountManager = new System.Windows.Forms.TextBox();
            this.txtPassword_AccountManager = new System.Windows.Forms.TextBox();
            this.cbxAccountLevel_AccountManager = new System.Windows.Forms.ComboBox();
            this.txtProfileLink_AccountManager = new System.Windows.Forms.TextBox();
            this.btnBrowse_AccountManager = new System.Windows.Forms.Button();
            this.picProfile_AccountManager = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave_AccountManager = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList_AccountManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile_AccountManager)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete_AccoutManager);
            this.groupBox1.Controls.Add(this.btnEdit_AccoutManager);
            this.groupBox1.Controls.Add(this.btnAdd_AccoutManager);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // btnDelete_AccoutManager
            // 
            this.btnDelete_AccoutManager.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_AccoutManager.Image")));
            this.btnDelete_AccoutManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete_AccoutManager.Location = new System.Drawing.Point(31, 147);
            this.btnDelete_AccoutManager.Name = "btnDelete_AccoutManager";
            this.btnDelete_AccoutManager.Size = new System.Drawing.Size(75, 23);
            this.btnDelete_AccoutManager.TabIndex = 2;
            this.btnDelete_AccoutManager.Text = "Delete";
            this.btnDelete_AccoutManager.UseVisualStyleBackColor = true;
            this.btnDelete_AccoutManager.Click += new System.EventHandler(this.btnDelete_AccoutManager_Click);
            // 
            // btnEdit_AccoutManager
            // 
            this.btnEdit_AccoutManager.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit_AccoutManager.Image")));
            this.btnEdit_AccoutManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit_AccoutManager.Location = new System.Drawing.Point(31, 104);
            this.btnEdit_AccoutManager.Name = "btnEdit_AccoutManager";
            this.btnEdit_AccoutManager.Size = new System.Drawing.Size(75, 23);
            this.btnEdit_AccoutManager.TabIndex = 1;
            this.btnEdit_AccoutManager.Text = "Edit";
            this.btnEdit_AccoutManager.UseVisualStyleBackColor = true;
            this.btnEdit_AccoutManager.Click += new System.EventHandler(this.btnEdit_AccoutManager_Click);
            // 
            // btnAdd_AccoutManager
            // 
            this.btnAdd_AccoutManager.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_AccoutManager.Image")));
            this.btnAdd_AccoutManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_AccoutManager.Location = new System.Drawing.Point(32, 60);
            this.btnAdd_AccoutManager.Name = "btnAdd_AccoutManager";
            this.btnAdd_AccoutManager.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_AccoutManager.TabIndex = 0;
            this.btnAdd_AccoutManager.Text = "Add";
            this.btnAdd_AccoutManager.UseVisualStyleBackColor = true;
            this.btnAdd_AccoutManager.Click += new System.EventHandler(this.btnAdd_AccoutManager_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridList_AccountManager);
            this.groupBox3.Location = new System.Drawing.Point(13, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List";
            // 
            // gridList_AccountManager
            // 
            this.gridList_AccountManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridList_AccountManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridList_AccountManager.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridList_AccountManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridList_AccountManager.Location = new System.Drawing.Point(7, 19);
            this.gridList_AccountManager.Name = "gridList_AccountManager";
            this.gridList_AccountManager.Size = new System.Drawing.Size(610, 168);
            this.gridList_AccountManager.TabIndex = 0;
            this.gridList_AccountManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridList_AccountManager_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profile";
            // 
            // txtUsername_AccountManager
            // 
            this.txtUsername_AccountManager.Location = new System.Drawing.Point(88, 20);
            this.txtUsername_AccountManager.Name = "txtUsername_AccountManager";
            this.txtUsername_AccountManager.Size = new System.Drawing.Size(218, 20);
            this.txtUsername_AccountManager.TabIndex = 4;
            // 
            // txtPassword_AccountManager
            // 
            this.txtPassword_AccountManager.Location = new System.Drawing.Point(88, 57);
            this.txtPassword_AccountManager.Name = "txtPassword_AccountManager";
            this.txtPassword_AccountManager.Size = new System.Drawing.Size(218, 20);
            this.txtPassword_AccountManager.TabIndex = 5;
            // 
            // cbxAccountLevel_AccountManager
            // 
            this.cbxAccountLevel_AccountManager.FormattingEnabled = true;
            this.cbxAccountLevel_AccountManager.Items.AddRange(new object[] {
            "--",
            "Admin",
            "Agent"});
            this.cbxAccountLevel_AccountManager.Location = new System.Drawing.Point(88, 94);
            this.cbxAccountLevel_AccountManager.Name = "cbxAccountLevel_AccountManager";
            this.cbxAccountLevel_AccountManager.Size = new System.Drawing.Size(218, 21);
            this.cbxAccountLevel_AccountManager.TabIndex = 6;
            // 
            // txtProfileLink_AccountManager
            // 
            this.txtProfileLink_AccountManager.Location = new System.Drawing.Point(88, 134);
            this.txtProfileLink_AccountManager.Name = "txtProfileLink_AccountManager";
            this.txtProfileLink_AccountManager.Size = new System.Drawing.Size(178, 20);
            this.txtProfileLink_AccountManager.TabIndex = 25;
            // 
            // btnBrowse_AccountManager
            // 
            this.btnBrowse_AccountManager.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse_AccountManager.Image")));
            this.btnBrowse_AccountManager.Location = new System.Drawing.Point(277, 134);
            this.btnBrowse_AccountManager.Name = "btnBrowse_AccountManager";
            this.btnBrowse_AccountManager.Size = new System.Drawing.Size(29, 20);
            this.btnBrowse_AccountManager.TabIndex = 26;
            this.btnBrowse_AccountManager.UseVisualStyleBackColor = true;
            this.btnBrowse_AccountManager.Click += new System.EventHandler(this.btnBrowse_AccountManager_Click);
            // 
            // picProfile_AccountManager
            // 
            this.picProfile_AccountManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile_AccountManager.Location = new System.Drawing.Point(324, 20);
            this.picProfile_AccountManager.Name = "picProfile_AccountManager";
            this.picProfile_AccountManager.Size = new System.Drawing.Size(120, 138);
            this.picProfile_AccountManager.TabIndex = 0;
            this.picProfile_AccountManager.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(489, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 138);
            this.panel1.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Profile";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave_AccountManager);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.picProfile_AccountManager);
            this.groupBox2.Controls.Add(this.btnBrowse_AccountManager);
            this.groupBox2.Controls.Add(this.txtProfileLink_AccountManager);
            this.groupBox2.Controls.Add(this.cbxAccountLevel_AccountManager);
            this.groupBox2.Controls.Add(this.txtPassword_AccountManager);
            this.groupBox2.Controls.Add(this.txtUsername_AccountManager);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(155, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atribute";
            // 
            // btnSave_AccountManager
            // 
            this.btnSave_AccountManager.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_AccountManager.Image")));
            this.btnSave_AccountManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave_AccountManager.Location = new System.Drawing.Point(141, 173);
            this.btnSave_AccountManager.Name = "btnSave_AccountManager";
            this.btnSave_AccountManager.Size = new System.Drawing.Size(75, 23);
            this.btnSave_AccountManager.TabIndex = 28;
            this.btnSave_AccountManager.Text = "Save";
            this.btnSave_AccountManager.UseVisualStyleBackColor = true;
            this.btnSave_AccountManager.Click += new System.EventHandler(this.btnSave_AccountManager_Click);
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 437);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccountManager";
            this.Text = "Account Manager";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList_AccountManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile_AccountManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete_AccoutManager;
        private System.Windows.Forms.Button btnEdit_AccoutManager;
        private System.Windows.Forms.Button btnAdd_AccoutManager;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridList_AccountManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername_AccountManager;
        private System.Windows.Forms.TextBox txtPassword_AccountManager;
        private System.Windows.Forms.ComboBox cbxAccountLevel_AccountManager;
        private System.Windows.Forms.TextBox txtProfileLink_AccountManager;
        private System.Windows.Forms.Button btnBrowse_AccountManager;
        private System.Windows.Forms.PictureBox picProfile_AccountManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave_AccountManager;
    }
}