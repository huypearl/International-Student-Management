namespace AdmissionTrackingApp
{
    partial class frmVisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisa));
            this.dtpDateOfExpiry_Visa = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfIssue_Visa = new System.Windows.Forms.DateTimePicker();
            this.rtxtNote_Visa = new System.Windows.Forms.RichTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnUpdate_VISA = new System.Windows.Forms.Button();
            this.txtType_Visa = new System.Windows.Forms.TextBox();
            this.txtNumber_Visa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow_frmVisa = new System.Windows.Forms.Button();
            this.btnBrowse_frmVisa = new System.Windows.Forms.Button();
            this.axAcroPDF3 = new AxAcroPDFLib.AxAcroPDF();
            this.lbId_Visa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateOfExpiry_Visa
            // 
            this.dtpDateOfExpiry_Visa.Location = new System.Drawing.Point(126, 144);
            this.dtpDateOfExpiry_Visa.Name = "dtpDateOfExpiry_Visa";
            this.dtpDateOfExpiry_Visa.Size = new System.Drawing.Size(208, 20);
            this.dtpDateOfExpiry_Visa.TabIndex = 74;
            // 
            // dtpDateOfIssue_Visa
            // 
            this.dtpDateOfIssue_Visa.Location = new System.Drawing.Point(126, 103);
            this.dtpDateOfIssue_Visa.Name = "dtpDateOfIssue_Visa";
            this.dtpDateOfIssue_Visa.Size = new System.Drawing.Size(208, 20);
            this.dtpDateOfIssue_Visa.TabIndex = 73;
            // 
            // rtxtNote_Visa
            // 
            this.rtxtNote_Visa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rtxtNote_Visa.Location = new System.Drawing.Point(126, 182);
            this.rtxtNote_Visa.Name = "rtxtNote_Visa";
            this.rtxtNote_Visa.Size = new System.Drawing.Size(208, 86);
            this.rtxtNote_Visa.TabIndex = 72;
            this.rtxtNote_Visa.Text = "";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(31, 185);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(30, 13);
            this.label38.TabIndex = 71;
            this.label38.Text = "Note";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(31, 109);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(72, 13);
            this.label37.TabIndex = 70;
            this.label37.Text = "Date Of Issue";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(31, 150);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 13);
            this.label34.TabIndex = 68;
            this.label34.Text = "Date Of Expiry";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(31, 90);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(0, 13);
            this.label35.TabIndex = 67;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(31, 63);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 13);
            this.label36.TabIndex = 66;
            this.label36.Text = "Type";
            // 
            // btnUpdate_VISA
            // 
            this.btnUpdate_VISA.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate_VISA.Image")));
            this.btnUpdate_VISA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_VISA.Location = new System.Drawing.Point(333, 294);
            this.btnUpdate_VISA.Name = "btnUpdate_VISA";
            this.btnUpdate_VISA.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate_VISA.TabIndex = 76;
            this.btnUpdate_VISA.Text = "Update";
            this.btnUpdate_VISA.UseVisualStyleBackColor = true;
            this.btnUpdate_VISA.Click += new System.EventHandler(this.btnUpdate_VISA_Click);
            // 
            // txtType_Visa
            // 
            this.txtType_Visa.Location = new System.Drawing.Point(126, 60);
            this.txtType_Visa.Name = "txtType_Visa";
            this.txtType_Visa.Size = new System.Drawing.Size(44, 20);
            this.txtType_Visa.TabIndex = 69;
            // 
            // txtNumber_Visa
            // 
            this.txtNumber_Visa.Location = new System.Drawing.Point(232, 60);
            this.txtNumber_Visa.Name = "txtNumber_Visa";
            this.txtNumber_Visa.Size = new System.Drawing.Size(102, 20);
            this.txtNumber_Visa.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Number";
            // 
            // btnShow_frmVisa
            // 
            this.btnShow_frmVisa.Location = new System.Drawing.Point(576, 36);
            this.btnShow_frmVisa.Name = "btnShow_frmVisa";
            this.btnShow_frmVisa.Size = new System.Drawing.Size(81, 23);
            this.btnShow_frmVisa.TabIndex = 89;
            this.btnShow_frmVisa.Text = "Show";
            this.btnShow_frmVisa.UseVisualStyleBackColor = true;
            this.btnShow_frmVisa.Click += new System.EventHandler(this.btnShow_frmVisa_Click);
            // 
            // btnBrowse_frmVisa
            // 
            this.btnBrowse_frmVisa.Location = new System.Drawing.Point(460, 36);
            this.btnBrowse_frmVisa.Name = "btnBrowse_frmVisa";
            this.btnBrowse_frmVisa.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse_frmVisa.TabIndex = 88;
            this.btnBrowse_frmVisa.Text = "Browse";
            this.btnBrowse_frmVisa.UseVisualStyleBackColor = true;
            this.btnBrowse_frmVisa.Click += new System.EventHandler(this.btnBrowse_frmVisa_Click);
            // 
            // axAcroPDF3
            // 
            this.axAcroPDF3.Enabled = true;
            this.axAcroPDF3.Location = new System.Drawing.Point(420, 74);
            this.axAcroPDF3.Name = "axAcroPDF3";
            this.axAcroPDF3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF3.OcxState")));
            this.axAcroPDF3.Size = new System.Drawing.Size(314, 192);
            this.axAcroPDF3.TabIndex = 87;
            // 
            // lbId_Visa
            // 
            this.lbId_Visa.AutoSize = true;
            this.lbId_Visa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId_Visa.Location = new System.Drawing.Point(122, 25);
            this.lbId_Visa.Name = "lbId_Visa";
            this.lbId_Visa.Size = new System.Drawing.Size(64, 13);
            this.lbId_Visa.TabIndex = 84;
            this.lbId_Visa.Text = "StudentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "ID";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(556, 116);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 13);
            this.label39.TabIndex = 85;
            this.label39.Text = "Show Visa Scan";
            // 
            // frmVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 329);
            this.Controls.Add(this.btnShow_frmVisa);
            this.Controls.Add(this.btnBrowse_frmVisa);
            this.Controls.Add(this.axAcroPDF3);
            this.Controls.Add(this.lbId_Visa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.txtNumber_Visa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate_VISA);
            this.Controls.Add(this.dtpDateOfExpiry_Visa);
            this.Controls.Add(this.dtpDateOfIssue_Visa);
            this.Controls.Add(this.rtxtNote_Visa);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.txtType_Visa);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Name = "frmVisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISA";
            this.Load += new System.EventHandler(this.frmVisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfExpiry_Visa;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue_Visa;
        private System.Windows.Forms.RichTextBox rtxtNote_Visa;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnUpdate_VISA;
        private System.Windows.Forms.TextBox txtType_Visa;
        private System.Windows.Forms.TextBox txtNumber_Visa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow_frmVisa;
        private System.Windows.Forms.Button btnBrowse_frmVisa;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF3;
        private System.Windows.Forms.Label lbId_Visa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label39;
    }
}